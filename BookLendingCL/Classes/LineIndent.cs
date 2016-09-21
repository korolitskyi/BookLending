using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookLending.Classes
{
    public abstract class LineIndent {

        private static LineIndent current;

        public static LineIndent Current {
            get { return LineIndent.current; }
            set {
                if (value == null) {
                    throw new ArgumentNullException(
                        "LineIndent.Current: value");
                }
                LineIndent.current = value;
            }
        }

        static LineIndent() {
            LineIndent.current =
                new DefaultLineIndent();
        }

        public abstract string Value { get; }

        public abstract void Increase();
        public abstract void Decrease();
        public abstract void Clear();

        public static void ResetToDefault() {
            LineIndent.current =
                new DefaultLineIndent();
        }
    }


    public class DefaultLineIndent : LineIndent{

        private int length = 0;

        private int step;
        private int maxLength;
        private char character;

        private string value = "";
        public override string Value { get { return value; } }

        public DefaultLineIndent(int step, int maxLength,
            char character) {
                this.step = step;
                this.maxLength = maxLength;
                this.character = character;
        }

        public DefaultLineIndent() : this(8, 40, ' ') { }

        public override void Increase() {
            if (this.length <= this.maxLength - this.step) {
                this.length += this.step;
                value = new String(this.character, this.length);
            }
        }

        public override void Decrease() {
            if (this.length >= this.step) {
                this.length -= this.step;
                value = new String(this.character, this.length);
            }
        }

        public override void Clear() {
            this.length = 0;
            this.value = "";
        }

    }
}
