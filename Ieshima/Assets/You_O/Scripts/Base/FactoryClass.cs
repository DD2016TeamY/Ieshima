//<<<<<<< HEAD
﻿//<<<<<<< HEAD
﻿using UnityEngine;
using System.Collections;

public class FactoryClass : MonoBehaviour {
    protected int ConstructionTime = -1; //建設期間
    protected int GetPower = 0; //取得電力
    protected bool Wind_PowerGeneratorFlag = false; //風力発電機フラグ
    protected bool ConstructedFlag = false; //建設済みフラグ

    //建設期間を減らす=======
﻿using UnityEngine;
using System.Collections;
=======
﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
//>>>>>>> 86f078c6b34ad19e8df5e68c7528423bdd80fd55

public class FactoryClass : BaseClass {
    protected int ConstructionTime = -1; //建設期間
    protected int GetPower = 0; //取得電力
    protected bool Wind_PowerGeneratorFlag = false; //風力発電機フラグ
    protected bool ConstructedFlag = false; //建設済みフラグ

<<<<<<< HEAD
    //建設期間を減らす>>>>>>> acfad6d467506e3b12782f0698a45f68f422b320
=======
    public List<GameObject> Wind_PowerGenerators = new List<GameObject>();

    //建設期間を減らす
>>>>>>> 86f078c6b34ad19e8df5e68c7528423bdd80fd55
    protected void DecreaseConstructionTime()
    {
        if(ConstructionTime > 0)
        {
            ConstructionTime--;
        }
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 86f078c6b34ad19e8df5e68c7528423bdd80fd55
    }

    //電力を受容する
<<<<<<< HEAD
=======0
    }

    //電力を受容する
>>>>>>> 22a789ee534c675f93e5a370a2661e3c1b224ec0
=======
>>>>>>> 86f078c6b34ad19e8df5e68c7528423bdd80fd55
    protected void SetPower()
    {
        if (STATIC_SPACE.StaticValue.ContractHamahimoDenryokuFlag)
        {
            GetPower = CONSTATIC_SPACE.ConstaticValue.PowerGanaration_of_Hamahimo;
        }
        else if (Wind_PowerGeneratorFlag)
        {
            GetPower = CONSTATIC_SPACE.ConstaticValue.WindPowerGenerate * Wind_PowerGenerators.Count;
        }
        else
        {
            GetPower = 0;
        }
    }
}
<<<<<<< HEAD
}
=======
>>>>>>> 86f078c6b34ad19e8df5e68c7528423bdd80fd55
