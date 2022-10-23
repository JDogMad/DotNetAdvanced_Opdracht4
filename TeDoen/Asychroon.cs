using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeDoen {
    internal class Asychroon {
        int Tijd { get; set; }

        public Asychroon(int tijd) {
            Tijd = tijd;
        }

        public async void toonOpJuisteMoment() {
            await Task.Factory.StartNew(new Func<int>(wait));
        }

        public int wait(){
            System.Threading.Thread.Sleep(Tijd);
            return Tijd;
        }
    }
}
