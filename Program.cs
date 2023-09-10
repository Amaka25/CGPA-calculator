internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int TotalweightPoint=0;
        int TotalCourseUnit=0;
        int TotalGradeUnit=0;
        int gradeunit=1;
        string grade;
        string Remark;
        for(int i=0; i<5; i++){
            
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
        }
        var table = new ConsoleTable("COURSE CODE", "COURSE UNIT", "GRADE","GRADE-UNIT","WEIGHT Pt","Remark");
        
         
        /*double GPA = TotalweightPoint / TotalCourseUnit;
        Console.WriteLine("Total Course Unit Registered is "+TotalCourseUnit);
        Console.WriteLine("Total Course Unit passed is "+TotalGradeUnit);
        Console.WriteLine("Total Weight Point is "+ TotalweightPoint);
        Console.WriteLine("Your GPA is" +GPA +" to 2 decimal places");*/
    }
}

internal class ConsoleTable
{
    private string v1;
    private string v2;
    private string v3;

    public ConsoleTable(string v1, string v2, string v3, string v)
    {
        this.v1 = v1;
        this.v2 = v2;
        this.v3 = v3;
    }

    public ConsoleTable(string v1, string v2, string v3, string v, string v4, string v5) : this(v1, v2, v3, v)
    {
        V4 = v4;
        V5 = v5;
    }

    public string V4 { get; }
    public string V5 { get; }
}