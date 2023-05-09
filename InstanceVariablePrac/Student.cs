namespace InstanceVariablePrac
{
    internal class Student
    {
        //internal은 기본 상태
        internal int grade;
        internal string name;

        public override string ToString()
        {
            return grade + "학년 " + name;
        }
    }
    //해시는 되도록 사용하지 말자 이퀄은 비교할 때 사용
}