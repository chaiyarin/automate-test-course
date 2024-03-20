namespace COURSE_TEMP_UNIT.FirstUnitTest
{
    public class GradeService
    {
        public string CalculateGrade(decimal point)
        {
            if (point > 100 || point < 0)
            {
                return "Invalid";
            }
            else
            {
                if (point < 60)
                {
                    return "F";
                }
                else
                {
                    if (point >= 60)
                    {
                        if (point < 70)
                        {
                            return "D";
                        }
                        else
                        {
                            if (point < 80)
                            {
                                return "C";
                            }
                            else
                            {
                                if (point < 90)
                                {
                                    return "B";
                                }
                                else
                                {
                                    return "A";
                                }
                            }
                        }
                    }
                    else
                    {
                        return "F";
                    }
                }
            }
        }
    }
}