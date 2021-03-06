namespace MIPS32
{
    public static class Patterns
    {
        public const string instruction_name = exclude_specific_registers + @"(?<nume_instr>\b[a-zA-Z]{2,}\b|\b[j]{1}\b|\b[a-zA-Z]{3}[0-1]{1}\b)\s*";//@"(?<nume_instr>\b[a-zA-Z]{3}[0-1]{1}\b|\b[j]{1}\b|\b[a-zA-Z]{2}\b|\b[a-zA-Z]{3}\b|\b[a-zA-Z]{4}\b|\b[a-zA-Z]{5}\b)\s*"; 
        public const string nonalphanumerical = @"[^a-zA-Z\d\s*]";
        public const string alpha = @"[a-zA-Z]";
        public const string numerical = @"[0-9]";
        public const string register_name = @"(?<nume_reg>\s*[$]\s*\w+\s*)";
        public const string paranthesis_open = @"\s*[(]\s*";
        public const string paranthesis_close = @"\s*[)]\s*";
        public const string shamt = @"\b[0][x](?<shamt_val>[0-9a-f]*)\b";
        public const string immediate = @"\b[0][x](?<immediate_val>[0-9a-f]*)\b";
        public const string offset = @"\b[0][x](?<offset_val>[0-9a-f]*)\b" + @"\s*[(]\s*" + register_name + @"\s*[)]\s*";
        public const string jump_address = @"\b[0][x](?<jmp_adr>[0-9a-f]*)\b";
        public const string exclude_specific_registers = @"(?!sp|at|zero|fp|gp|ra|\s|$)";
    }
}
