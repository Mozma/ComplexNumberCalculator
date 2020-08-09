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
        private long real;
        private long imaginary;

        public long Real { get { return real; } }
        public long Imaginary { get { return imaginary; } }
        public ComplexNumber(long real, long imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        #region Operations
        
        #region Logic
        public static bool operator ==(ComplexNumber numb1, ComplexNumber numb2)
        {
            return (numb1.real == numb2.real) && (numb1.imaginary == numb2.imaginary); 
        }
        public static bool operator !=(ComplexNumber numb1, ComplexNumber numb2)
        {
            return (numb1.real != numb2.real) || (numb1.imaginary != numb2.imaginary);
        }
        #endregion

        #region Math
        public static ComplexNumber operator +(ComplexNumber numb1, ComplexNumber numb2)
        {
            return new ComplexNumber(numb1.real + numb2.real, numb1.imaginary + numb2.imaginary);
        }

        public static ComplexNumber operator -(ComplexNumber numb1, ComplexNumber numb2)
        {
            return new ComplexNumber(numb1.real - numb2.real, numb1.imaginary - numb2.imaginary);
        }

        public static ComplexNumber operator *(ComplexNumber numb1, ComplexNumber numb2)
        {
            // (ac - bd) + i(ad + bc)
            var result = new ComplexNumber(
                numb1.real * numb2.real - numb1.imaginary * numb2.imaginary, 
                numb1.real * numb2.imaginary + numb1.imaginary * numb2.real
                );

            return result;
        }

        public static ComplexNumber operator /(ComplexNumber numb1, ComplexNumber numb2)
        {
            return new ComplexNumber(numb1.real - numb2.real, numb1.imaginary - numb2.imaginary);
        }

        #endregion

        #endregion

        #region Functions

        public override string ToString()
        {
            if(imaginary > 0)
            {
                return $"{real}{imaginary}i";
            }
            else
            {
                return $"{real}+{imaginary}i";
            }
        }

        #endregion
    }
}
