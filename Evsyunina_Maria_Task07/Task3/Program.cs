using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public interface ISeries
    {
        double GetCurrent();
        bool MoveNext();
        void Reset();
    }

    public interface IIndexable
    {
        double this[int index] { get; }
    }

    public class ArithmeticalProgression : ISeries, IIndexable
    {
        double start, step;
        int currentIndex;

        public ArithmeticalProgression(double start, double step)
        {
            this.start = start;
            this.step = step;
            this.currentIndex = 1;
        }

        public double GetCurrent()
        {
            return start + step * currentIndex;
        }

        public bool MoveNext()
        {
            currentIndex++;
            return true;
        }

        public void Reset()
        {
            currentIndex = 1;
        }

        public double this[int index]
		{
			get
			{
				return start + step * index;
			}
		}
    }


    public class List : ISeries, IIndexable
        {
            private double[] series;
            private int currentIndex;

            public List(double[] series)
            {
                this.series = series;
                currentIndex = 0;
            }

            public double GetCurrent()
            {
                return series[currentIndex];
            }

            public bool MoveNext()
            {
                currentIndex = currentIndex < series.Length - 1 ? currentIndex + 1 : 0;
                return true;
            }

            public void Reset()
            {
                currentIndex = 0;
            }

            public double this[int index]
            {
                get { return series[index]; }
            }
        }

 }