using UnityEngine;

public class PauseSetup : MonoBehaviour
{ 
      private readonly PauseModel _model = new PauseModel(); 
              
      public void Resolve(Initable<PauseModel> target)
      { 
            target.Init(_model);
      } 
}
