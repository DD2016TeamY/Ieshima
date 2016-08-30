using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace STATIC_SPACE
{
    public class StaticValue : MonoBehaviour
    {
        public static int NationalTreasury = 0;    //国庫
        public static int Population = 10;  //人口
        public static int Month = 0;   //月数
        public static int MaxYear = 0; //最大年数
        public static List<int> NationalTreasuryPerMonth;   //各月の国庫
        public static List<int> PopulationGrowthRatePerMonth;  //各月の人口増加率
        public static bool ContractHamahimoDenryokuFlag = false;   //浜紐電力との契約フラグ
        public static bool TyphoonFlag = false;    //台風フラグ
        public static int BrandPower_of_Cow = 1;   //牛のブランド力
        public static int BrandPower_of_Rum = 1;   //ラム酒のブランド力
        public static int Tourists = 0;    //観光客数

        void Start()
        {
            NationalTreasuryPerMonth.Add(NationalTreasury);
            PopulationGrowthRatePerMonth.Add(Population);
        }
    }
}