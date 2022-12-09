using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattrens
{
    // Invoker 
    internal class Program
    {
        private CommandExcute _commandExcure;
        public Program()
        {

        }
        static void Main(string[] args)
        {


            Console.ReadKey();
        }
    }
    // ref
    public interface Command
    {
        void Excute();
    }
    // Sender 
    class CoptyTextReceiver : Command
    {
        private TextEditor _text;
        public CoptyTextReceiver(TextEditor text)
        {
            this._text = text;
        }
        public void Excute()
        {
            _text.Coptytext();
        }
    }
    class PasteTextReceiver : Command
    {
        private TextEditor _text;
        public PasteTextReceiver(TextEditor text)
        {
            this._text = text;
        }
        public void Excute()
        {
            _text.PasteText();
        }
    }
    // Receiver
    class TextEditor
    {
        public void Coptytext()
        {
            //some text here
        }
        public void PasteText()
        {
            // some text her
        }
    }

}

