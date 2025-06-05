using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chip8_Emu.Models
{
    public class Chip8Constants
    {
        public const int MemorySize = 4096;
        public const int RegisterCount = 16;
        public const int StackSize = 16;
        public const int ScreenWidth = 64;
        public const int ScreenHeight = 32;
        public const int ProgramStartAddress = 0x200;
        public const int FontStartAddress = 0x50;
    }
}
