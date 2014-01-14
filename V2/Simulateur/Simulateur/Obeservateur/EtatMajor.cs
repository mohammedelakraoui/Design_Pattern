using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simulateur.Obeservateur
{
  public interface  EtatMajor
    {
       /* void Order(StateChange stateChange);
        void Process(StateChange stateChange, StateChangeOptions options);
        void Process(StateChange stateChange, StateChangeOptions options, IPropagator sender);
        void AddDependent(IPropagator dependent, bool biDirectional);
        void RemoveDependent(IPropagator dependent, bool biDirectional);
        void RemoveAllDependents(bool biDirectional);*/
      void Configurer();
      void Order(Object PourUnePersonne);
    }
}
