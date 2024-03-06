namespace ConsoleApp1
{
    public class qualityPointScore
    {

        public double qualityPoint { get;  set; }
        public double unitGrade { get; set; }
        public double courseUnit { get; set; }

        public void SetqulityPoint(double courseUnit, double gradeUnit)
        {
            this.qualityPoint = (courseUnit * gradeUnit);
        }  public void SetcourseUnit(double qualityPoint, double gradeUnit)
        {
            this.courseUnit = (qualityPoint / gradeUnit);
        }
        
    }

}

