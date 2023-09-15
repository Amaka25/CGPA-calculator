using System.Data;

internal class Program
{
    public class Course
{
    public string? CourseCode { get; set; }
    public int CourseUnit { get; set; }
    public string? Grade { get; set; }
    public int GradeUnit { get; set; }
 public int Weight { get; set; }
  public string? Remark { get; set; }
}
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int TotalweightPoint=0;
        int TotalCourseUnit=0;
        int TotalGradeUnit=0;
        int gradeunit=1;
        string grade = "";
        string Remark = "";

        var finalCourseCode = new List<Course>();
        
        for(int i=0; i<2; i++){
            
            Console.WriteLine("Enter the "+(i+1)+"st Course code: ");
            string CourseCode= Console.ReadLine();
            Console.WriteLine("Enter the Course unit: ");
            int courseUnit= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the score: ");
            int score= Convert.ToInt32(Console.ReadLine());
            if(score >=70){
                grade= "A";
                gradeunit = 5;
                Remark="Excellent";
            }
            else if(score >= 60){
                grade= "B";
                gradeunit = 4;
                Remark="Very Good";
            }
            else if(score >= 50){
                grade= "C";
                gradeunit = 3;
                Remark="Good";
            }
            else if(score >= 45){
                grade= "D";
                gradeunit = 2;
                Remark="Fair";
            }
            else if(score >= 40){
                grade= "E";
                gradeunit = 1;
                Remark="Pass";
            }
            else if(score <= 39){
                grade= "F";
                gradeunit = 0;
                Remark="Fail";
            }
            else if(score >100 && score < 0 ){
                Console.WriteLine("Enter valid score");
            }
            int weightPoint = gradeunit * courseUnit;
            TotalweightPoint +=weightPoint;
            TotalCourseUnit += courseUnit;  
            TotalGradeUnit += gradeunit;

            finalCourseCode.Add(new Course
            {
                CourseCode = CourseCode,
                CourseUnit = courseUnit,
                Grade = grade,
                GradeUnit = gradeunit,
                Remark = Remark,
                Weight = weightPoint
            }) ;
        }
        // string myCourseCode = CourseCode.ToString();
        // string mycourseUnit = courseUnit.ToString();
        // string mygrade = grade.ToString();
        // string myWeightpoint = weightPoint.ToString();
        ConsoleTable.PrintLine();
        ConsoleTable.PrintRow("COURSE CODE", "COURSE UNIT","GRADE","GRADE UNIT","WEIGHT pt","REMARK");
        ConsoleTable.PrintLine();

        foreach(var course in finalCourseCode)
        {
            ConsoleTable.PrintRow(course.CourseCode,course.CourseUnit.ToString(),course.Grade,course.GradeUnit.ToString(),course.Weight.ToString(),course.Remark);
        }

        
        
         
        /*double GPA = TotalweightPoint / TotalCourseUnit;
        Console.WriteLine("Total Course Unit Registered is "+TotalCourseUnit);
        Console.WriteLine("Total Course Unit passed is "+TotalGradeUnit);
        Console.WriteLine("Total Weight Point is "+ TotalweightPoint);
        Console.WriteLine("Your GPA is" +GPA +" to 2 decimal places");*/
    }
}



public static class ConsoleTable
{
    static int tablewidth = 70;
    public static void PrintLine()
    {
        Console.WriteLine(new string('-', tablewidth));

    }
    public static void PrintRow(params string[] columns)
    {

        int width= (tablewidth - columns.Length)/columns.Length;
        string row = "|";
        foreach(string column in columns){
            row += AlignCentre(column,width) + "|";
        }
        Console.WriteLine(row);
    }

    private static string AlignCentre(string text, int width)
    {
        text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;
        if (string.IsNullOrEmpty(text))
        {
            return new string(' ', width);
        }
        else
        {
            return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
        }
    }

}