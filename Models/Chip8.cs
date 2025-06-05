using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chip8_Emu.Models
{
    public class Chip8
    {
        byte[] memory = new byte[Chip8Constants.MemorySize];
        byte[] registers = new byte[Chip8Constants.RegisterCount];
        Stack<ushort> stack = new Stack<ushort>(Chip8Constants.StackSize);
        ushort pc; // Program Counter

    }
}
