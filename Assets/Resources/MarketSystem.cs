using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MarketSystem : MonoBehaviour
{

    public static MarketSystem Instance;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    [SerializeField] private int money;
    [SerializeField] private int cash;
    
    private int selectedCarNumber;
    public GameObject car;
    public GameObject mainMenuCamera;
    public Text money_text;
    public Text cash_text;
    public Image buyButton;
    public GameObject garage;
    public Image priceImage;
    public Sprite money_icon;
    public Sprite cash_icon;
    public Text car_prices;
    public List<GameObject> purchased_cars = new List<GameObject>(3);
    public List<GameObject> cars = new List<GameObject>();
    public GameObject SelectedCar;


    [SerializeField] private Button previousButton;
    [SerializeField] private Button nextButton;
    private int currentCarNumber = 0;
    public GameObject marketArea;





    public int getMoney()
    {
        return this.money;
    }

    public int getCash()
    {
        return this.cash;
    }
    private void SelectCar(int _index)
    {
        for (int i = 0; i < cars.Count; i++)
        {
            cars[i].gameObject.SetActive(i == _index);
        }
    }

    public void ChangeCar(int _change)
    {
        if (_change == 1)
        {
            if (currentCarNumber != cars.Count - 1)
            {
                currentCarNumber += _change;
            }
            else
            {
                currentCarNumber = 0;
            }
        }
        else
        {
            if (currentCarNumber != 0)
            {
                currentCarNumber += _change;
            }
            else
            {
                currentCarNumber = cars.Count - 1;
            }
        }
        selectedCarObeject();
        CarSituation();
        SelectCar(currentCarNumber);
    }
    public void carBuy()
    {
        if (cars[currentCarNumber].GetComponent<CarProperties>().CarPriceInMoney <= getMoney() && cars[currentCarNumber].GetComponent<CarProperties>().CarPriceInCash <= getCash())
        {
            this.money = this.money - cars[currentCarNumber].GetComponent<CarProperties>().CarPriceInMoney;
            this.cash = this.cash - cars[currentCarNumber].GetComponent<CarProperties>().CarPriceInCash;
            purchased_cars.Add(cars[currentCarNumber]);
            selectedCarObeject();
            CarSituation();
            MoneyandCashUpdade();
        }
        else
        {
            Debug.Log("Your Money is not enough");
        }
     
    }
    private void Start()
    {
        MoneyandCashUpdade();
        SelectedCar = cars[0];
        SelectCar(0);
        purchased_cars.Add(cars[0]);
        CarSituation();
    }

    void Update()
    {

    }
    
    void MoneyandCashUpdade()
    {
        money_text.text = getMoney().ToString();
        cash_text.text = getCash().ToString();
    }
    
    public void CarSituation()
    {
        if (purchased_cars.Contains(cars[currentCarNumber]) == true)
        {
            car_prices.gameObject.SetActive(false);
            priceImage.gameObject.SetActive(false);
            buyButton.gameObject.SetActive(false);
        } 
        else
        {
            car_prices.gameObject.SetActive(true);
            priceImage.gameObject.SetActive(true);
            buyButton.gameObject.SetActive(true);
        }
        if (cars[currentCarNumber].GetComponent<CarProperties>().CarType == "coin")
        {
            priceImage.sprite = money_icon;
            car_prices.text = cars[currentCarNumber].GetComponent<CarProperties>().CarPriceInMoney.ToString();
        }
        else
        {
            priceImage.sprite = cash_icon;
            car_prices.text = cars[currentCarNumber].GetComponent<CarProperties>().CarPriceInCash.ToString();
        }

    }

    public void selectedCarObeject()
    {
        if (purchased_cars.Contains(cars[currentCarNumber]) == true)
        {
            SelectedCar = cars[currentCarNumber];
            selectedCarNumber = currentCarNumber;
        }
    }

    public void mainMenuCar()
    {
        if (cars[currentCarNumber] != SelectedCar)
        {
            cars[currentCarNumber].SetActive(false);
            SelectedCar.gameObject.SetActive(true);
        }

    }

    public void toMainMenu()
    {
        currentCarNumber = selectedCarNumber;
        CarSituation();
    }

 

}
