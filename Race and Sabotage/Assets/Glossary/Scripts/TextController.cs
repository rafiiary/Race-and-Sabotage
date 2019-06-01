
using TMPro;
using UnityEngine;

public class TextController : MonoBehaviour
{
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI definitionText;
    public TextMeshProUGUI exampleText;

    /* The currently chosen concept */
    concept currConcept;



    // Start is called before the first frame update. We will always start with the Variable option
    void Start()
    {
        /* Text for variables */
        concept variable = new concept();
        variable.setTitle("Variable");
        variable.setDef("A Variable is a quantity that has been assigned a special value by the programmer.\n" +
            " It is like a box holding a value, in the sense that you can use the box instead of using the value directly!");
        variable.setExample("For Example: x = 10 implies 2 + x = 12 \n" +
            "We can substitute 10 by x anywhere necessary. This provides a nice and neat way to modify our programs.");

        //Always start with variable and change accordingly
        currConcept = variable;
        updateTexts();
    }


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
