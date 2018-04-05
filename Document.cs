using System;

public class Document 
{
	public static void Trans(dynamic i, dynamic o)
	{
        // Takes the loan number input and grabs the last 6 digits - outputs to LoanNum
        o.LoanNum = i.InputLoanNumber.Substring(i.InputLoanNumber.Length - 6);
		
        // Creates a new array to split the Borrower Name input String
        String[] NameSplit = new String[] {""};
		String FullName = i.InputBorrowerName;
        
        // Sets the Separator value to " "
		String[] Separators = new String[] {" "};

        // Splits FullName into an array of each part of the name, and then grabs the last item in the Array as the BorrowerLastName
		NameSplit = FullName.Split(Separators, StringSplitOptions.RemoveEmptyEntries);
		o.BorrowerLastName = NameSplit[NameSplit.Length - 1].ToUpper();
	}
}