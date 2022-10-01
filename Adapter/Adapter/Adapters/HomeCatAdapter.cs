using Adapter.HomeCat;
using Adapter.HomeDog;

namespace Adapter.Adapters
{
    class HomeCatAdapter : IHomeCat
    {
        private IHomeDog _homeDog;

        public HomeCatAdapter(IHomeDog dog)
        {
            _homeDog = dog;
        }

        public string Name { get => _homeDog.NickName; set { } } 

        public void Meow()
        {
            _homeDog.Voice();
        }

        public void Sleep()
        {
            _homeDog.Sleep();
        }
    }
}
