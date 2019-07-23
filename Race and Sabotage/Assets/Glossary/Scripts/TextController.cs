using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI definitionText;
    public TextMeshProUGUI exampleText;
    public GameObject dropDown;

    /* The currently chosen concept */
    concept currConcept;
    concept variable;
    concept condition;
    concept forloops;
    concept whileloops;
    //concept final;
    public static int currentChosenOption;

    /* Start is called before the first frame update. Define all concepts */
    void Start()
    {
        //Which dropdown option are we looking at?
        currentChosenOption = dropDown.GetComponent<TMP_Dropdown>().value;

        /* Text for variables */
        variable = new concept();
        variable.setTitle("Variables");
        variable.setDef("A Variable is a quantity that has been assigned a special value by the programmer.\n" +
            " It is like a box holding a value, in the sense that you can use the box instead of using the value directly!");
        variable.setExample("For Example: x = 10 implies 2 + x = 12 \n" +
            "We can substitute 10 by x anywhere necessary. This provides a nice and neat way to modify our programs.");

        /*Text for Conditions */
        condition = new concept();
        condition.setTitle("Conditional Statements");
        condition.setDef("Conditional statements control the flow of the program and allow it to behave appropriately under different circumstances.\n" +
            "They include 'if statements' which can be followed by 'else if' and 'else' statements which execute appropriate behaviours accordingly.");
        condition.setExample("For example \n" +
            "'if(x){do y}\n" +
            "else{do z}'\n" +
            "will execute y given x is true and execute z otherwise.");

        /*Text for For Loops*/
        forloops = new concept();
        forloops.setTitle("For Loops");
        forloops.setDef("For Loops help programmers execute chunks of code in multiple interations without having to repeat the code! They are \n" + 
            "a very powerful tool that helps programmers iterate over data structures like arrays, and execute shared pieces of code among \n" +
            "say, the different indices of the array, or even multiple arrays!");
        forloops.setExample("For loops have syntax like\n " +
        	"for (int i = 0; i< value; i++){some code}\n" +
            " to signify that the code is meant to iterate value times, with each iteration differing by 1.");

        /*Text for While Loops*/
        whileloops = new concept();
        whileloops.setTitle("While Loops");
        whileloops.setDef("While loops help programmers execute chunks of code, guided by a condition. While the condition is true, the code \n" +
            "keeps executing. When the condition falsifies, the while loop stops execution.\n");
        whileloops.setExample( "The syntax for a while loop is the following: \n" +
            "while(i < value){some code}.\n" +
            "The 'some code' contains ways for iteration.");

        /*Text for the final race*/
        //final = new concept();
        //final.setTitle("The final race!");
        //final.setDef("This is the final chapter of this race! This covers all the chapters we have learned so far. Be prepared for the following:");
        //final.setExample("VARIABLES, \n IF CONDITIONS, \n WHILE LOOPS, \n FOR LOOPS");

        decideCurrConcept();
        updateTexts();
    }

    /* Update which concept is currently chosen and update texts
     * Will be run when value of dropdown is changed */
    public void decideCurrConcept()
    {
        currentChosenOption = dropDown.GetComponent<TMP_Dropdown>().value;
        switch (currentChosenOption) {
            case 0:
                currConcept = variable;
                break;
            case 1:
                currConcept = condition;
                break;
            case 2:
                currConcept = forloops;
                break;
            case 3:
                currConcept = whileloops;
                break;
            //case 4:
            //    currConcept = final;
            //    break;

        }
        updateTexts();
    }

    /* Update current texts to current concept chosen */
    void updateTexts()
    {
        titleText.SetText(currConcept.getTitle());
        definitionText.SetText(currConcept.getDef());
        exampleText.SetText(currConcept.getExample());
    }

    /* Concept class will hold onto all definitions of the title, definition, and example texts */
    class concept
    {
        string title, definition, example;
        public void setTitle(string title)
        {
            this.title = string.Copy(title);
        }
        public string getTitle()
        {
            return title;
        }
        public void setDef(string def)
        {
            definition = string.Copy(def);
        }
        public string getDef()
        {
            return definition;
        }
        public void setExample(string example)
        {
            this.example = string.Copy(example);
        }
        public string getExample()
        {
            return example;
        }
    }
}
