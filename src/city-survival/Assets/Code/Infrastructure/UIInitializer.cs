using UnityEngine;
using Zenject;

namespace Code.Infrastructure
{
    public class UIInitializer : MonoBehaviour, IInitializable
    {
      //  private IWindowFactory _windowFactory;
    //
      //  public RectTransform UIRoot;
//
      //  [Inject]
      //  private void Construct(IWindowFactory windowFactory) => 
      //      _windowFactory = windowFactory;
    //
      //  public void Initialize() => 
      //      _windowFactory.SetUIRoot(UIRoot);
      public void Initialize()
      {
        throw new System.NotImplementedException();
      }
    }
}