using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._06.Services
{
    internal class Starter
    {
        public delegate Task Common();

        public Common handler;

        public event Common FillEvent;

        public event Common FillEvent2;

        public Starter()
        {
            this.handler = FillFile;
            this.handler = FillFileSec;
        }

        public async Task FillFile()
        {
            var json = new JSONReader();
            var num = json.Reader();
            var stable = json.Reader();
            Random random = new Random();

            for (int i = 1; i <= 50; i++)
            {
                var date = DateTime.Now.ToString("hh_mm_fffffff dd-MM-yyyy");
                string path = @"D:\C# A level\24.06\24.06\Backup\" + date + ".txt";

                for (int j = i; j <= num; j++)
                {
                    using (StreamWriter writer = new StreamWriter(path, true))
                    {
                        int nxt = random.Next(1, 4);
                        if (nxt == 1)
                        {
                            var loggerInfo = new Models.Logger("Info", date, "OK");
                            string info = $"{loggerInfo.Name} {loggerInfo.DateTime} {loggerInfo.Message}";
                            await writer.WriteLineAsync(info);
                        }
                        else if (nxt == 2)
                        {
                            var loggerWarning = new Models.Logger("Warning", date, "Oops! we have a problem...");
                            string warning = $"{loggerWarning.Name} {loggerWarning.DateTime} {loggerWarning.Message}";
                            await writer.WriteLineAsync(warning);
                        }
                        else if (nxt == 3)
                        {
                            var loggerError = new Models.Logger("Error", date, "huge error");
                            string error = $"{loggerError.Name} {loggerError.DateTime} {loggerError.Message}";
                            await writer.WriteLineAsync(error);
                        }
                    }

                }

                i = num;
                num = num + stable;
            }
        }

        public async Task FillFileSec()
        {
            var json = new JSONReader();
            var num = json.Reader();
            var stable = json.Reader();
            Random random = new Random();

            for (int i = 1; i <= 50; i++)
            {
                var date = DateTime.Now.ToString("hh_mm_fffffff dd-MM-yyyy");
                string path = @"D:\C# A level\24.06\24.06\Backup\" + date + ".txt";

                for (int j = i; j <= num; j++)
                {
                    using (StreamWriter writer = new StreamWriter(path, true))
                    {
                        int nxt = random.Next(1, 4);
                        if (nxt == 1)
                        {
                            var loggerInfo = new Models.Logger("Info", date, "OK");
                            string info = $"{loggerInfo.Name} {loggerInfo.DateTime} {loggerInfo.Message}";
                            await writer.WriteLineAsync(info);
                        }
                        else if (nxt == 2)
                        {
                            var loggerWarning = new Models.Logger("Warning", date, "Oops! we have a problem...");
                            string warning = $"{loggerWarning.Name} {loggerWarning.DateTime} {loggerWarning.Message}";
                            await writer.WriteLineAsync(warning);
                        }
                        else if (nxt == 3)
                        {
                            var loggerError = new Models.Logger("Error", date, "huge error");
                            string error = $"{loggerError.Name} {loggerError.DateTime} {loggerError.Message}";
                            await writer.WriteLineAsync(error);
                        }
                    }

                }

                i = num;
                num = num + stable;
            }
        }

        public void Open()
        {
            FillEvent.EndInvoke(FillFile());
            FillEvent2.EndInvoke(FillFileSec());
        }
    }
}