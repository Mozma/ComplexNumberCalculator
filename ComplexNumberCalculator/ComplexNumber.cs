using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumberCalculator
{
    struct ComplexNumber
    {
        long real;
        long imaginary;

        public ComplexNumber(long real, long imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        #region Operations
        
        public static bool operator ==(ComplexNumber numb1, ComplexNumber numb2)
        {
            return (numb1.real == numb2.real) && (numb1.imaginary == numb2.imaginary); 
        }
        public static bool operator !=(ComplexNumber numb1, ComplexNumber numb2)
        {
            return (numb1.real != numb2.real) || (numb1.imaginary != numb2.imaginary);
        }

        
        public static ComplexNumber operator +(ComplexNumber numb1, ComplexNumber numb2)
        {
            return new ComplexNumber(numb1.real + numb2.real, numb1.imaginary + numb2.imaginary);
        }

        public static ComplexNumber operator -(ComplexNumber numb1, ComplexNumber numb2)
        {
            return new ComplexNumber(numb1.real + numb2.real, numb1.imaginary + numb2.imaginary);
        }

        #endregion
    }
}
