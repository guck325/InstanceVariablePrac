namespace InstanceVariablePrac
{
    class Product
    {
        public static string origin = "한국";
        public string name="default";
        public int price = 0;

        //overide 자바에서는 위에 overide가 적혀있음
        //ToString는 오버라이딩
        public override string ToString()
        {
            return "이름 :" + this.name + " / 가격 :" + this.price;
        }
    }
}