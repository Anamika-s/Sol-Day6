using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Generics_Properties
{// Access specifiers > They tell abt the scope or visibility  or accessbility of 
    // the class/class members
    // private 
    // public
    // protected, used in inheritance only
    // internal, member will be available anywhere in the same project
    // internal protected
      class Student
    {
        int id;
        // properties are warppers around the variables
        // they are used to access the varibales outside the class thru properties
        // property has to be public
        // it has 2 methods , get , set
        // get is used to retrurn value of the variable
        // set is used to store value in variable
        public int Id
        {
            get 
            {
                return id; 
            } 
            set
            {
             id= value;
            }
        }
        string name;
        public string Name
        {
            get {

                return name;
            }
            set
            {
                name = value;
            }
        }
        string batch;
        public string Batch
        {
            get { return batch; }
            set { batch = value; }
        }
        public void Get() {  }
        public void Display() { }

    }
}
