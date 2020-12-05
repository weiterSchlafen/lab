using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba4
{
    // "AbstractProductB" 
    public abstract class AbstractProperties
    {
        public abstract string madeProperties();
    }

    // "ProductB1" 
    public class PropertiesDrevolaz : AbstractProperties
    {
        public override string madeProperties()
        {
            return @"Домен:	Эукариоты
Царство: Животные
Тип:	Хордовые
Класс:	Земноводные
Отряд:	Бесхвостые земноводные
Семейство: Древолазы";
        }
    }

    // "ProductB2" 
    public class PropertiesVodonos : AbstractProperties
    {
        public override string madeProperties()
        {

            return @"Домен:	Эукариоты
Царство:	Животные
Тип:	Хордовые
Класс:	Земноводные
Отряд:	Бесхвостые земноводные
Семейство:	Pyxicephalidae
Род:	Pyxicephalus
Вид:	Роющая лягушка";
        }
    }
}
