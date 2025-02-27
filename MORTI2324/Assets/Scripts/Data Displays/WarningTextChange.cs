using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WarningTextChange : MonoBehaviour
{
    private float delay = 1;

    private List<string> listOfWarnings = new List<string>();
    public Image WarningSymbol;
    public TMP_Text Warning_Text;
    public AbnormalValues checker;
    private string printList = "";

    public ErrorContainer container;

    void Start()
    {
        StartCoroutine(UpdateValues2Sec());
    }

    
       IEnumerator UpdateValues2Sec()
        {   
            yield return new WaitForSeconds(1);
            while (true){
            printList = "";
            listOfWarnings.Clear();
            WarningSymbol.gameObject.SetActive(false);
            
            if (container.getO2Error()){
                listOfWarnings.Add("O2 Error Detected!");
            }

            if (container.getPumpError()){
                listOfWarnings.Add("Pump Error Detected!");
            }

            if (container.getPowerError()){
                listOfWarnings.Add("Power Error Detected!");
            }

            if (container.getFanError()){
                listOfWarnings.Add("Fan Error Detected!");
            }

            // if (checker.PrimaryOxygenLow()){
            //     listOfWarnings.Add("Primary Oxygen Low!");
            // }

            // if (checker.SecondaryOxygenLow()){
            //     listOfWarnings.Add("Secondary Oxygen Low!");
            // }

            // if (checker.BPMLow()){
            //     listOfWarnings.Add("Heart Rate Slow!");
            // }

            // if(checker.BPMHigh()){
            //     listOfWarnings.Add("Heart Rate High!");
            // }

            // if(checker.SubPressureLow()){
            //     listOfWarnings.Add("External Pressure Low!");
            // }

            // if (checker.SubPressureHigh()){
            //     listOfWarnings.Add("External Pressure High!");
            // }

            // if (checker.SuitPressureLow()){
            //     listOfWarnings.Add("Suit Pressure Low!");
            // }

            
            // if (checker.SuitPressureHigh()){
            //     listOfWarnings.Add("Suit Pressure High!");
            // }

            // if (checker.FanSpeedLow()){
            //     listOfWarnings.Add("Suit Fan Speed Slow!");
            // }

            // if (checker.FanSpeedHigh()){
            //     listOfWarnings.Add("Suit Fan Speed High!");
            // }

            // if (checker.OxygenPressureLow()){
            //     listOfWarnings.Add("Primary Oxygen Pressure Low!");
            // }

            // if (checker.OxygenPressureHigh()){
            //     listOfWarnings.Add("Primary Oxygen Pressure High!");
            // }

            // if (checker.OxygenRateLow()){
            //     listOfWarnings.Add("Oxygen Flow Rate Low!");
            // }

            // if (checker.OxygenRateHigh()){
            //     listOfWarnings.Add("Oxygen Flow Rate High!");
            // }

            // if (checker.BatteryCapacityLow()){
            //     listOfWarnings.Add("Battery Capaciy Low!");
            // }

            // if (checker.H20GasPressureLow()){
            //     listOfWarnings.Add("H2O Gas Pressure Low!");
            // }

            // if (checker.H20GasPressureHigh()){
            //     listOfWarnings.Add("H2O Gas Pressure High");
            // }

            // if (checker.H20LiquidPressureLow()){
            //     listOfWarnings.Add("H2O Liquid Pressure Low!");
            // }

            // if (checker.H20LiquidPressureHigh()){
            //     listOfWarnings.Add("H2O Liquid Pressure High!");
            // }

            // if (checker.SecondaryOxygenPressureLow()){
            //     listOfWarnings.Add("Secondary Oxygen Pressure Low!");
            // }

            // if (checker.SecondaryOxygenPressureHigh()){
            //     listOfWarnings.Add("Secondary Oxygen Pressure High!");
            // }

            // if (checker.SecondaryOxygenRateLow()){
            //     listOfWarnings.Add("Secondary Oxyegn Flow Rate Low!");
            // }

            // if (checker.SecondaryOxygenRateLow()){
            //     listOfWarnings.Add("Secondary Oxygen Flow Rate High!");
            // }

            // if (checker.BatteryLow()){
            //     listOfWarnings.Add("Battery Is Low!");
            // }
            

            if (listOfWarnings.Count >= 1){
                WarningSymbol.gameObject.SetActive(true);
            }


            foreach(string x in listOfWarnings){
                printList += x;
                printList += "\n";
            }
            
            Warning_Text.text = printList;
            yield return new WaitForSeconds(2);
        }
        }

    
    }
