using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace Swed32
{
    public class Swed
    {
        #region imports

        [DllImport("Kernel32.dll")]
        static extern bool ReadProcessMemory(
            IntPtr hProcess,
            IntPtr lpBaseAddress,
            [Out] byte[] lpBuffer,
            int nSize,
            IntPtr lpNumberOfBytesRead
        );

        [DllImport("kernel32.dll")]
        static extern bool WriteProcessMemory(
            IntPtr hProcess,
            IntPtr lpBaseAddress,
            byte[] lpBuffer,
            int size,
            IntPtr lpNumberOfBytesWritten
        );

        [DllImport("kernel32.dll")]
        static extern IntPtr CreateFile(
            string lpFileName,
            uint dwDesiredAccess,
            uint dwShareMode,
            IntPtr lpSecurityAttributes,
            uint dwCreationDisposition,
            uint dwFlagsAndAttributes,
            IntPtr hTemplateFile
        );

        [DllImport("kernel32.dll")]
        static extern bool CloseHandle(IntPtr hObject);

        #endregion

        #region globals

        private Process proc;

        #endregion

        public Swed(string procName)
        {
            proc = SetProcess(procName);
        }

        public Process GetProcess()
        {
            return proc;
        }

        public Process SetProcess(string procName)
        {
            try
            {

                Process[] processes = Process.GetProcessesByName(procName);
                if (processes.Length > 0)
                {
                    proc = processes[0];
                }
                else
                {
                    throw new InvalidOperationException("Process was not found, are you using the correct bit version and have no misspellings?");
                }
                return proc;
            }
            catch
            {
                return null;
            }
        }

        public IntPtr GetModuleBase(string moduleName)
        {
            if (string.IsNullOrEmpty(moduleName))
            {
                throw new InvalidOperationException("moduleName was either null or empty.");
            }

            if (proc == null)
            {
                throw new InvalidOperationException("process is invalid, check your init.");
            }

            try
            {
                if (moduleName.Contains(".exe"))
                {
                    if (proc.MainModule != null)
                    {
                        return proc.MainModule.BaseAddress;
                    }
                }

                foreach (ProcessModule module in proc.Modules)
                {
                    if (module.ModuleName == moduleName)
                    {
                        return module.BaseAddress;
                    }
                }
            }
            catch (Exception)
            {
                throw new InvalidOperationException("Failed to find the specified module, search string might have misspellings.");
            }

            return IntPtr.Zero;
        }

        public IntPtr ReadPointer(IntPtr addy)
        {
            byte[] buffer = new byte[4];
            ReadProcessMemory(proc.Handle, addy, buffer, buffer.Length, IntPtr.Zero);
            return (IntPtr)BitConverter.ToInt32(buffer, 0);
        }

        public IntPtr ReadPointer(IntPtr addy, int offset)
        {
            byte[] buffer = new byte[4];
            ReadProcessMemory(proc.Handle, addy + offset, buffer, buffer.Length, IntPtr.Zero);
            return (IntPtr)BitConverter.ToInt32(buffer, 0);
        }

        // Add other ReadPointer overloads as needed

        // Implement ReadInt, ReadFloat, ReadShort, ReadUShort, ReadUInt methods similarly

        // Implement Write methods similarly

        public byte[] ReadBytes(IntPtr addy, int bytes)
        {
            byte[] buffer = new byte[bytes];
            ReadProcessMemory(proc.Handle, addy, buffer, buffer.Length, IntPtr.Zero);
            return buffer;
        }

        // Implement other ReadBytes overloads as needed

        // Implement ReadVec, ReadMatrix, WriteVec, Nop methods similarly

        public IntPtr ScanForBytes32(string moduleName, string needle)
        {
            ProcessModule module = proc.Modules.OfType<ProcessModule>().FirstOrDefault(x => x.ModuleName == moduleName) ?? throw new InvalidOperationException("Module was not found. Check your module name.");

            byte[] needleBytes = needle.Split(' ').Select(b => Convert.ToByte(b, 16)).ToArray();
            byte[] haystackBytes;

            if (module.FileName == null)
            {
                throw new InvalidOperationException("Module filename was null.");
            }

            using (var stream = new FileStream(module.FileName, FileMode.Open, FileAccess.Read))
            {
                haystackBytes = new byte[stream.Length];
                stream.Read(haystackBytes, 0, (int)stream.Length);
            }
            return (IntPtr)ScanForBytes32(haystackBytes, needleBytes);
        }

        public float ReadFloat(IntPtr address)
        {
            try
            {
                byte[] buffer = new byte[4];
                ReadProcessMemory(proc.Handle, address, buffer, buffer.Length, IntPtr.Zero);
                return BitConverter.ToSingle(buffer, 0);
            }
            catch
            {
                return 0;
            }
        }

        public float ReadFloat(IntPtr address, int offset)
        {
            try
            {
                byte[] buffer = new byte[4];
                ReadProcessMemory(proc.Handle, address + offset, buffer, buffer.Length, IntPtr.Zero);
                return BitConverter.ToSingle(buffer, 0);
            }
            catch
            {
                return 0;
            }
        }

        public bool WriteFloat(IntPtr address, float value)
        {
            try
            {
                byte[] bytes = BitConverter.GetBytes(value);
                return WriteProcessMemory(proc.Handle, address, bytes, bytes.Length, IntPtr.Zero);
            }
            catch
            {
                return false;
            }
        }

        public bool WriteFloat(IntPtr address, int offset, float value)
        {
            try
            {
                byte[] bytes = BitConverter.GetBytes(value);
                return WriteProcessMemory(proc.Handle, address + offset, bytes, bytes.Length, IntPtr.Zero);
            }
            catch
            {
                return false;
            }
        }


        public int ScanForBytes32(byte[] haystack, byte[] needle)
        {
            for (int i = 0; i < haystack.Length - needle.Length; i++)
            {
                bool found = true;
                for (int j = 0; j < needle.Length; j++)
                {
                    if (haystack[i + j] != needle[j])
                    {
                        found = false;
                        break;
                    }
                }
                if (found)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool WriteInt(IntPtr address, int value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            return WriteProcessMemory(proc.Handle, address, bytes, bytes.Length, IntPtr.Zero);
        }

        public bool WriteInt(IntPtr address, int offset, int value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            return WriteProcessMemory(proc.Handle, address + offset, bytes, bytes.Length, IntPtr.Zero);
        }

        public int ReadInt(IntPtr address)
        {
            byte[] buffer = new byte[4];
            ReadProcessMemory(proc.Handle, address, buffer, buffer.Length, IntPtr.Zero);
            return BitConverter.ToInt32(buffer, 0);
        }

        public int ReadInt(IntPtr address, int offset)
        {
            byte[] buffer = new byte[4];
            ReadProcessMemory(proc.Handle, address + offset, buffer, buffer.Length, IntPtr.Zero);
            return BitConverter.ToInt32(buffer, 0);
        }

    }
}
