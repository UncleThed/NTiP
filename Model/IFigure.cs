using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Фигура
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// Рассчитать объем фигуры.
        /// </summary>
        /// <returns></returns>
        double Volume { get;}

        /// <summary>
        /// Получить тип фигуры
        /// </summary>
        string Type { get; }
    }
}
