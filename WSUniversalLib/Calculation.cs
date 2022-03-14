using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUniversalLib
{
    public class Calculation
    {
        public static int GetQuantityForProduct(int productType, int materialType, int count, float width, float length)
        {
            try
            {
                if (count > 0 && width > 0 && length > 0)
                {
                    float CountArea = (width * length) * count, ProductTypeVarification;
                    int ResultindValue;
                    switch (productType)
                    {
                        case 1:
                            ProductTypeVarification = GetQuantityWithoutMarriage(1, CountArea);
                            break;
                        case 2:
                            ProductTypeVarification = GetQuantityWithoutMarriage(2, CountArea);
                            break;
                        case 3:
                            ProductTypeVarification = GetQuantityWithoutMarriage(3, CountArea);
                            break;
                        default:
                            return -1;
                    }
                    if (ProductTypeVarification == -1)
                    {
                        return -1;
                    }
                    else
                    {
                        switch (materialType)
                        {
                            case 1:
                                ResultindValue = Convert.ToInt32(GetQuantity(1, ProductTypeVarification));
                                return ResultindValue;
                            case 2:
                                ResultindValue = Convert.ToInt32(GetQuantity(2, ProductTypeVarification));
                                return ResultindValue;
                            default:
                                return -1;
                        }
                    }
                }
                else
                {
                    return -1;
                }
            }
            catch
            {

                return - 1;
            }
            
            
        }

        public static float GetQuantityWithoutMarriage  (int productType, float CountArea) 
        {
            switch (productType)
            {
                case 1:                   
                    return CountArea * 1.1f;
                case 2:
                    return CountArea * 2.5f;
                case 3:
                    return CountArea * 8.43f;
                default:
                    return -1;
            }
        }

        public static float GetQuantity(int materialType, float CountWithoutMarriage)
        {
            switch (materialType)
            {
                case 1:
                    return CountWithoutMarriage * 1.003f;
                case 2:
                    return CountWithoutMarriage * 1.0012f;
                default:
                    return -1;
            }
        }
    }
}
