using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTJeopardy.Utilities
{
    public struct QandAs
    {
        public string question;
        public string answer;
        public int row;
        public int col;
        public int value;
    }

    public class DataMethods
    {
        List<QandAs> dataBank = new List<QandAs>();

        private QandAs findSelectionData(int row, int col)
        {
            var matchedObject =
                   (from t in dataBank
                    where t.row == row && t.col == col
                    select t).FirstOrDefault();

            return matchedObject;
        }

        internal async void PrepareToSendToAlex(int row, int col, HostScreen screen)
        {
            QandAs result = findSelectionData(row, col);
            var questionResult = await Task.Run(() => screen.DataToAlex(result.answer, result.question));
        }

        public void LoadAnswers(int row, int col)
        {
            // Create new instance for struct
            QandAs data = new QandAs();

            data.answer = "row = " + row.ToString() + " : col = " + col.ToString();
            data.question = "Who is JT?";
            data.row = row;
            data.col = col;

            dataBank.Add(data);
        }
    }
}
