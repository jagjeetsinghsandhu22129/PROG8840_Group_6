namespace Calculator{
    public class Evaluator{
        public static float Eval(string Operator, params float[] Operands){
            float result;
            switch(Operator){
                case "+":
                    result = Add.Eval(Operands[0], Operands[1]);
                    break;
                case "-":
                    result = Subtract.Eval(Operands[0], Operands[1]);
                    break;
                case "*":
                    result = Multiply.Eval(Operands[0], Operands[1]);
                    break;
                case "/":
                    result = Divide.Eval(Operands[0], Operands[1]);
                    break;
                case "%":
                    result = Modulo.Eval(Operands[0], Operands[1]);
                    break;
                case "^":
                    result = Power.Eval(Operands[0], Operands[1]);
                    break;
                case "sqrt": // Square root case
                    if (Operands.Length != 1)
                    {
                        throw new ArgumentException("Square root requires exactly one operand.");
                    }
                    result = SquareRoot.Eval(Operands[0]);
                    break;

                case "per":
                    result = Percentage.Eval(Operands[0], Operands[1]);
                    break;

                case "store":
                    if (Operands.Length != 1)
                    {
                        throw new ArgumentException("Store requires exactly one operand.");
                    }
                    Memory.Store(Operands[0]);
                    result = Operands[0];
                    break;
                case "recall":
                    result = Memory.Recall();
                    break;
                case "clear":
                    Memory.Clear();
                    result = 0;
                    break;

                case "factorial":
                    if (Operands.Length != 1)
                    {
                        throw new ArgumentException("Factorial requires exactly one operand.");
                    }
                    result = Factorial.Eval(Operands[0]);
                    break;

                default:
                    throw new Exception("unimplemented");
            }
            return result;
        }
    }

}