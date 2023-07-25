using System;
using System.Collections.Generic;
using System.Linq;

namespace Self_Checkout_Simulator
{
    class LooseItemScale
    {
        // Attributes
        SelfCheckout selfCheckout;
        bool enabled = false;

        // Operations
        public void Enable()
        {
            enabled = true;
        }

        public void Disable()
        {
            enabled = false;
        }

        public bool IsEnabled()
        {

            return enabled;
        }

        public void LinkToSelfCheckout(SelfCheckout selfCheckout)
        {
            this.selfCheckout = selfCheckout;
        }

        // NOTE: In reality the weight wouldn't be passed in here, the
        //       scale would detect the change and notify the self checkout
        public void WeightChangeDetected(int weight)
        {
            if (weight != 0)
                selfCheckout.LooseItemAreaWeightChanged(weight);
        }
    }
}