using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Functions to complete:
/// - Create Names
/// - Set Individual Name
/// - Set Team Character Names
/// </summary>
public class CharacterNameGenerator : MonoBehaviour
{
 
    [Header("Possible first names")]
    private List<string> firstName = new List<string>(); // a list of all possible first names for us to use.
    [Header("Possible last names")]
    private List<string> lastName = new List<string>(); // a list of all possible last names for us to use.
    [Header("Possible nicknames")]
    private List<string> nickName = new List<string>(); // a list of all possible nick names for us to use.


    private void Awake()
    {
        // call the create names function
        CreateNames();
    }

    /// <summary>
    /// Creates a list of names for all our characters to potentiall use.
    /// </summary>
    public void CreateNames()
    {
        // So here we would ideally want to be able to add some names to our first names, last names and nick names lists.
        
        firstName.Add("Sand");
        firstName.Add("Sweet");
        firstName.Add("Night");
        firstName.Add("Butter");
        firstName.Add("Cheese");
        firstName.Add("Custurd");
        lastName.Add("Witch");
        lastName.Add("James");
        lastName.Add("Less");
        lastName.Add("Jam");
        lastName.Add("Jelly");
        lastName.Add("Choco");
        nickName.Add("Smooth");
        nickName.Add("like");
        nickName.Add("Butter");
        nickName.Add("Criminal");
        nickName.Add("Under");
        nickName.Add("Cover");

    }

    /// <summary>
    /// set a characters name to a random value in our Part 02
    /// </summary>
    /// <param name="character"></param>
    public void SetIndividualCharacter(CharacterName character)
    {
        // So here rather than each character being called Blanky Blank Blank, we probably want it to be a random first,last and nickname
        character.firstName = firstName[Random.Range(0,firstName.Count)];
        character.lastName = lastName[Random.Range(0,lastName.Count)];
        character.nickName = nickName[Random.Range(0,nickName.Count)];
    }

    /// <summary>
    /// sets a character name for each member of a team, this is in our part 03
    /// </summary>
    /// <param name="namesNeeded"></param>
    /// <returns></returns>
    public void SetTeamCharacterNames(List<CharacterName> teamCharacters)
    {
        // so here we have a list of character names coming in.
        // we should probably loop over that list of charcter names, and then for each chacter set thei first, last and nickname a random one from our lists
        // if you want to get fancy you could use another function within this script to help out here.
        for(int i = 0; i < teamCharacters.Count; i++)
        {
            teamCharacters[i].firstName = firstName[Random.Range(0, firstName.Count)];
            teamCharacters[i].lastName = lastName[Random.Range(0, lastName.Count)];
            teamCharacters[i].nickName = nickName[Random.Range(0, nickName.Count)];
        }
        
    }
}