namespace Kocaeli_Travel_App
{
    class Commander
    {

        NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

       
        public void InfoLogger (string text)
        {
            logger.Info(text);         
        }
        public void FatalErrorLogger(string text)
        {
            logger.Fatal(text);
            logger.Error(text);
        }
        public void WarnLogger(string text)
        {
            logger.Warn(text);      
        }
        public void DebugLogger(string text)
        {
            logger.Debug(text);
        }
        public void TraceLogger(string text)
        {
            logger.Trace(text);
        }
    }
    public class MyList<T>
    {

        
        public Node<T> _head;
        public T Data;
        public void myAdd(T d)
        {
            
            Node<T> newNode = new Node<T>(d);
            Node<T> current = _head; 

            if (_head == null)
            {
                _head = newNode;
            }
            else
            {
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
                //TODO neden current'teki değişiklik _head'ı etkiliyor traverse işlemi

            }
        }


        
    }
}
