using System;
using System.Collections.Generic;
using System.Linq;

namespace Self_Checkout_Simulator
{
    class BaggingAreaScale
    {
        // Attributes
        private int weight = 0;
        private int expected = 0;
        private int allowedDifference = 0;

        private SelfCheckout selfCheckout;

        // Operations
        public int GetCurrentWeight()
        {
            return weight;
        }

        public bool IsWeightOk()
        {
            if (expected == weight)
                return true;
            else
                return false;
        }

        public int GetExpectedWeight()
        {
            return expected;
        }

        public void SetExpectedWeight(int expected)
        {
            this.expected = expected;
        }

        public void OverrideWeight()
        {
            if (!IsWeightOk())
            {
                weight += selfCheckout.GetCurrentProduct().GetWeight();
            }
            else
            {
                weight = expected;
            }
        }

        public void Reset()
        {
            weight = 0;
            expected = 0;
            allowedDifference = 0;
        }

        public void LinkToSelfCheckout(SelfCheckout selfCheckout)
        {
            this.selfCheckout = selfCheckout;
        }

        // NOTE: In reality the difference wouldn't be passed in here, the
        //       scale would detect the change and notify the self checkout
        public void WeightChangeDetected(int difference)
        {
            selfCheckout.GetCurrentProduct().SetWeight(difference);
            selfCheckout.BaggingAreaWeightChanged();
        }
    }
}