using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beispiel_Rechteck
{
  class Rechteck
  {
    static void class rechteck {}

    public void setSeiteA(double value) {
      if (value < 10)
        value = 10;
      _seiteA = value;
    }
    public void setSeiteB(double value) {
      if (value < 10)
        value = 10;
      _seiteB = value;
    }
  }
}
