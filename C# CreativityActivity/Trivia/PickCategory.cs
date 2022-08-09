public enum MainCategory { Game, Movie, Music, Sports }

public class PickCategory {
    
    private MainCategory whichMainCategory;
    private List<ITrivia> listOfCategories = new List<ITrivia>();

    public PickCategory(MainCategory userChosenCategory)
    {
        this.whichMainCategory = userChosenCategory;
    }

    public List<KeyValuePair<string, ListOfQuestions>> GetSubcategories() {
        List<KeyValuePair<string, ListOfQuestions>> listOfSubCategories = new List<KeyValuePair<string, ListOfQuestions>>();

        switch (this.whichMainCategory) {
            case MainCategory.Game:
                listOfSubCategories.Add(new KeyValuePair<string, ListOfQuestions>("Beat Saber", new ListOfQuestions()));
                listOfSubCategories.Add(new KeyValuePair<string, ListOfQuestions>("Dead by Daylight", new ListOfQuestions()));
                listOfSubCategories.Add(new KeyValuePair<string, ListOfQuestions>("RocketLeague", new ListOfQuestions()));
                listOfSubCategories.Add(new KeyValuePair<string, ListOfQuestions>("ApexLegends", new ListOfQuestions()));
                break; 
            case MainCategory.Music:
                listOfSubCategories.Add(new KeyValuePair<string, ListOfQuestions>("Rap", new ListOfQuestions()));
                listOfSubCategories.Add(new KeyValuePair<string, ListOfQuestions>("Rock", new ListOfQuestions()));
                listOfSubCategories.Add(new KeyValuePair<string, ListOfQuestions>("RnB", new ListOfQuestions()));
                listOfSubCategories.Add(new KeyValuePair<string, ListOfQuestions>("Pop", new ListOfQuestions()));
                break;
            case MainCategory.Sports:
                listOfSubCategories.Add(new KeyValuePair<string, ListOfQuestions>("Football", new ListOfQuestions()));
                listOfSubCategories.Add(new KeyValuePair<string, ListOfQuestions>("Baseball", new ListOfQuestions()));
                listOfSubCategories.Add(new KeyValuePair<string, ListOfQuestions>("Basketball", new ListOfQuestions()));
                listOfSubCategories.Add(new KeyValuePair<string, ListOfQuestions>("Wrestling", new ListOfQuestions()));
                break;
            case MainCategory.Movie:
                listOfSubCategories.Add(new KeyValuePair<string, ListOfQuestions>("Walt Disney Studio Animation", new ListOfQuestions()));
                listOfSubCategories.Add(new KeyValuePair<string, ListOfQuestions>("Pixar Animation Studios", new ListOfQuestions()));
                listOfSubCategories.Add(new KeyValuePair<string, ListOfQuestions>("Studio Ghibli", new ListOfQuestions()));
                break;
                

        }
        return listOfSubCategories;
    }
}