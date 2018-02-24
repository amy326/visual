using System;

namespace hello
{
      class Student
      {
            static void Main()
            {
                  //姓名
                  string name;
            public string Name
            {
                  get { return this.name; }
                  set
                  {
                        if (value == " ")
                        {
                              throw new ArgumentException("姓名字段不能为空");
                              this.name = value;
                        }
                  }
            }

            //年龄
            int age;
            public int Age
            {
                  get { return this.age; }
                  set
                  {
                        if (value < 1 || value > 100)
                        {
                              throw new ArgumentException("年龄超出范围");
                              this.age = value;

                        }
                  }
            }
   
            }

      }
}
