//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Program.patterns.Chain_of_responsibility_pattern
//{
//    public abstract class LoanHandler
//    {
//        protected LoanHandler successor;

//        public void SetSuccessor(LoanHandler successor)
//        {
//            this.successor = successor;
//        }

//        public abstract bool ApproveLoan(Loan loan);
//    }

//    public class CreditScoreHandler : LoanHandler
//    {
//        public override bool ApproveLoan(Loan loan)
//        {
//            if (loan.CreditScore >= 700)
//            {
//                if (successor != null)
//                {
//                    return successor.ApproveLoan(loan);
//                }
//                return true; // Loan approved
//            }
//            return false; // Loan rejected
//        }
//    }

//    public class IncomeHandler : LoanHandler
//    {
//        public override bool ApproveLoan(Loan loan)
//        {
//            if (loan.Income >= 50000)
//            {
//                if (successor != null)
//                {
//                    return successor.ApproveLoan(loan);
//                }
//                return true; // Loan approved
//            }
//            return false; // Loan rejected
//        }
//    }

//    // other handlers for other checks (debt-to-income ratio, collateral, etc.)

//    public class Loan
//    {
//        public int CreditScore { get; set; }
//        public decimal Income { get; set; }
//        // other properties

//        public Loan(int creditScore, decimal income)
//        {
//            CreditScore = creditScore;
//            Income = income;
//            // other property assignments
//        }
//    }

//    public class Program
//    {
//        public static void Main()
//        {
//            Loan loan = new Loan(750, 60000);

//            LoanHandler creditScoreHandler = new CreditScoreHandler();
//            LoanHandler incomeHandler = new IncomeHandler();

//            creditScoreHandler.SetSuccessor(incomeHandler);

//            bool isApproved = creditScoreHandler.ApproveLoan(loan);

//            if (isApproved)
//            {
//                Console.WriteLine("Loan approved!");
//            }
//            else
//            {
//                Console.WriteLine("Loan rejected.");
//            }

//        }

//    }



//}
