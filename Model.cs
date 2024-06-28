using ILOG.CPLEX;
using ILOG.Concert;

namespace CplexModelProject
{
    public class Model
    {
        public void Solve()
        {
            Cplex cplex = new Cplex();
            
            // 定義變量、目標函數和約束條件

            if (cplex.Solve())
            {
                // 輸出結果
                Console.WriteLine($"Objective Value: {cplex.ObjValue}");
            }
            else
            {
                Console.WriteLine("No solution found.");
            }

            cplex.End();
        }
    }
}
