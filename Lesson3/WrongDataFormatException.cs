using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.Lesson3
{
    public class WrongDataFormatException:FormatException
    {
        private string messageDatail = "Вы ввели некорректные данные !";

        public override string Message => $"Операция отклонена! Причина: {messageDatail}";

    }
}
