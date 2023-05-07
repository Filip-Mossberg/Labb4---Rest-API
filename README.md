# Labb4---Rest-API

1. Hämta alla personer i systemet
How?: /api/Person/AllPersons and just click 'Execute'

2. Hämta alla intressen som är kopplade till en specifik person
How?: /api/Person/hobbies/{id} and add an number (id:int) between 1 and 10

3. Hämta alla länkar som är kopplade till en specifik person
How?: /api/Person/links/{id} and add an number (id:int) between 1 and 10

4. Koppla en person till ett nytt intresse
How?: /api/Person/NewHobby and add the following 
{
  "personID": 4,
  "hobbyID": 2,
  "linkID": 5
}
you can modify these however you want within the conditions below. 
1. Person id between 1 and 10
2. Hobby id between 1 and 4
3. Link id between 1 and 10

5. Lägga in nya länkar för en specifik person och ett specifikt intresse
How?: /api/link and add the following 
First you will have to add a Person id between 1 and 10 plus a Hobby id between 1 and 4
Then add create insert make a list of Link objects like shown below
[
  {
    "linkName": "Twitch",
    "url": "https://www.twitch.tv/"
  },
  {
    "linkName": "GitHub",
    "url": "https://github.com/"
  }
]

6. (Extra) So I crated another [HttpGet] method to be able to see all links that belong togeather with a specified Hobby
How?: /api/Link/HobbyLinks/{id} and insert a Hobby id between 1 and 4 
