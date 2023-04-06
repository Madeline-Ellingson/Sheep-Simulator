using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Assets.Scripts.Data;

public class Sheep : MonoBehaviour
{
    // ***********************
    // *** Class Variables ***
    // ***********************

    // Static counter to keep track of sheep
    private static int sheepCount = 0;

    // Identifying Traits
    private int id = -1;
    private new string name = "n/a";
    private string sex = "n/a";
    private bool isDeceased = false;

    // Family Tree
    private FamilyTree familyTree = new FamilyTree();

    // Production Traits
    private double stapleLength = 0.0;
    private double quality = 0;
    private double yield = 0.0;
    private double fleeceWeight = 0.0;
	private WoolColor woolColor;

    // Health Traits
    private double foodConsumption = 0.0;
    private double waterConsumption = 0.0;
    private int health = 0;

    // Disease Resistance - Genetic
    private double wormResistance = 0.0;

    // *******************
    // *** Gets & Sets ***
    // *******************

    // Identifying Traits
    public int ID 
    {
        get { return this.id; }
        set 
        {
			sheepCount++;
			this.id = sheepCount;
        }
    }
    public string Name 
    {
        get { return this.name; }
        set { this.name = value; }
    }
    public string Sex 
    {
        get { return this.sex; }
        set
        {
            if(value == "Male" || value == "Female")
            {
                this.sex = value;
            }
            else
            {
                throw new ArgumentException("Expected: Male or Female for attribute Sex\n" +
					                      "Actual: " + value);
            }
        }
    }
    public bool IsDeceased
    {
        get { return this.isDeceased; }
        set { this.isDeceased = value; }
    }

    // Family Tree
    public FamilyTree FamilyTree 
    {
        get { return this.familyTree; }
        set { this.familyTree = value; }
    }

    // Production Traits
    public double StapleLength 
    {
        get { return this.stapleLength; }
        set
        {
            if (value > 0)
            {
                this.stapleLength = value;
            }
            else
            {
                throw new ArgumentException("Expected: Double greater than 0.0 for attribute Staple Length\n" +
					                      "Actual: " + value);
            }
        }
    }
    public double Quality 
    {
        get { return this.quality; }
        set
        {
            if(value >= 0.0)
            {
                this.quality = value;
            }
            else
            {
                throw new ArgumentException("Expected: Non-negative double for attribute Quality\n" +
                                          "Actual: " + value);
            }
        }
    }
    public double Yield {
        get { return this.yield; }
        set
        {
            if(value >= 0.0)
            {
                this.yield = value;
            }
            else
            {
				throw new ArgumentException("Expected: Non-negative double for attribute Yield\n" +
						  "Actual: " + value);
			}
        }
    }
    public double FleeceWeight 
    {
        get { return this.fleeceWeight; }
        set
        {
			if (value >= 0.0)
			{
				this.fleeceWeight = value;
			}
			else
			{
				throw new ArgumentException("Expected: Non-negative double for attribute Fleece Weight\n" +
										  "Actual: " + value);
			}
		}
    }
    public WoolColor WoolColor 
    {
        get { return this.woolColor; }
        set
		{
			if (Enum.IsDefined(typeof(WoolColor), value))
			{
				this.woolColor = value;
			}
			else
			{
				throw new ArgumentException("Invalid wool color for generic sheep.");
			}
		}
    }

    // Health Traits
    public double FoodConsumption
    {
        get { return this.foodConsumption; }
        set
        {
			if (value > 0.0)
			{
				this.foodConsumption = value;
			}
			else
			{
				throw new ArgumentException("Expected: Double greater than 0.0 for attribute Food Consumption\n" +
										  "Actual: " + value);
			}
		}
    }
    public double WaterConsumption 
    {
        get { return this.waterConsumption; }
        set
		{
			if (value > 0.0)
			{
				this.waterConsumption = value;
			}
			else
			{
				throw new ArgumentException("Expected: Double greater than 0.0 for attribute Water Consumption\n" +
										  "Actual: " + value);
			}
		}
    }
    public int Health 
    {
        get { return this.Health; }
        set
        {
			if (value >= 0)
			{
				this.health = value;

                if(this.Health == 0)
                {
                    this.isDeceased = true;
                }
			}
			else
			{
				throw new ArgumentException("Expected: Non-negative integer for attribute Health\n" +
										  "Actual: " + value);
			}
		}
    }

    // Disease Resistance - Genetic
    public double WormResistance 
    {
        get { return this.wormResistance; }
        set
        {
			if (value > 0.0)
			{
				this.wormResistance = value;
			}
			else
			{
				throw new ArgumentException("Expected: Double greater than 0.0 for attribute Worm Resistance\n" +
										  "Actual: " + value);
			}
		}
    }

    // ********************
    // *** Constructors ***
    // ********************

    // ***************
    // *** Methods ***
    // ***************

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
