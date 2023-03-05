using System;

namespace GL2023_Updater {
   class Program {
      static void Main(string[] args) {
         var updater = new Updater();
         updater.IsUpdated().Wait();
      }
   }
}
