using DoggyPedia.Model;

namespace DoggyPedia.Data
{
    public static class DogData
    {
        public static IList<Dog> Dogs { get; private set; }

        static DogData()
        {
            Dogs =
            [
                new Dog()
                {
                    Name = "German Shepherd",
                    Description = "Breed of working dog developed in Germany from traditional herding and farm dogs. " +
                    "It is a strongly built and relatively long-bodied dog. Its dense coat consists of coarse, medium-long, " +
                    "straight or slightly wavy outer hair and soft short inner hair; " +
                    "its color ranges from white or pale gray to black and is commonly gray and black or black and tan. Noted for intelligence, alertness, and loyalty, " +
                    "the German Shepherd is widely used as a watchdog and a guide dog for the blind and serves in police and military roles.",
                    ImagePath = "german_shepherd.jpg"
                },
                new Dog()
                {
                    Name = "English Bulldog",
                    Description = "Breed of dog developed centuries ago in England for use in fighting bulls (bullbaiting). " +
                    "Characteristically powerful and courageous, often vicious, and to a great extent unaware of pain, " +
                    "the Bulldog nearly disappeared when dogfighting was outlawed in 1835. " +
                    "Fanciers of the breed, however, saved it and bred out its ferocity. " +
                    "Nicknamed the “sourmug,” the Bulldog is a stocky dog that moves with a rolling gait. " +
                    "It has a large head, folded ears, a short muzzle, a protruding lower jaw, and loose skin that forms wrinkles on the head and face.",
                    ImagePath = "english_bulldog.jpg"
                },
                new Dog()
                {
                    Name = "Golden Retriever",
                    Description = "Breed of sporting dog developed in Scotland in the 19th century as a gundog and water retriever to assist hunters in recovering game birds. " +
                    "It is a strong and hardy all-around dog and an excellent swimmer. " +
                    "Its thick coat is long on the neck, thighs, tail, and back of the legs and may be any shade of golden brown. " +
                    "The Golden Retriever was first shown in England in 1908 and was registered with the American Kennel Club in 1925. " +
                    "Golden Retrievers are one of the most popular dog breeds in the United States. " +
                    "The breed is noted for being friendly, gentle, and willing to work, and it makes an excellent family pet. " +
                    "Golden Retrievers also have been trained as guide dogs for the blind.",
                    ImagePath = "golden_retriever.jpg"
                },
                new Dog()
                {
                    Name = "Siberian Husky",
                    Description = "Breed of strong, graceful, and friendly working dog raised in Siberia by the Chukchi people, who valued it as a sled dog and companion. " +
                    "It was brought to Alaska in 1909 for sled dog races and soon became established as a consistent winner. " +
                    "In 1925 the breed gained widespread fame by saving Nome, Alaska, during a diphtheria epidemic; " +
                    "teams of Siberian Huskies battled blizzard conditions to relay life-saving serum over 674 miles (1,085 km) to the icebound city. " +
                    "The effort became known as the “Great Race of Mercy,” and the annual Iditarod Trail Sled Dog Race commemorates the accomplishment. " +
                    "The lead dog in the final stretch of the 1925 relay, Balto, became world famous, and a statue of him stands in New York City’s Central Park.",
                    ImagePath = "siberian_husky.jpg"
                },
                new Dog()
                {
                    Name = "Dachshund",
                    Description = "Dog breed of hound and terrier ancestry developed in Germany to pursue badgers into their burrows. " +
                    "The Dachshund (whose name means “badger dog” in German) is a long-bodied, characteristically lively dog " +
                    "with a deep chest, short legs, tapering muzzle, and long ears. " +
                    "Usually reddish brown or black-and-tan, it is bred in two sizes—standard and miniature—and in three coat types—smooth, longhaired, and wirehaired.",
                    ImagePath = "dachshund.jpg"
                },
                new Dog() 
                { 
                    Name = "Labrador Retriever",
                    Description = "Breed of sporting dog that originated in Newfoundland and was brought to England by fishermen about 1800. " +
                    "It is an outstanding gun dog, consistently dominating field trials. More solidly built than other retrievers and with shorter legs, " +
                    "its distinctive features include an otterlike tail, thick at the base and tapered toward the end, " +
                    "and its short dense coat of black, brown (“chocolate”), or yellow. The Labrador Retriever is characteristically rugged, even-tempered, and gentle. " +
                    "It has been used in military and police work, as a rescue dog, and as a guide dog for the blind. An ideal family pet, " +
                    "the Labrador Retriever became in the 1990s the most popular dog breed in the United States. " +
                    "It reigned as the American Kennel Club’s top registered breed for 31 straight years, until the French Bulldog took the top spot in 2022.",
                    ImagePath = "labrador_retriever.jpg"
                },
                new Dog()
                {
                    Name = "Bernese Mountain Dog",
                    Description = "Bernese Mountain Dog, breed of working dog taken to Switzerland more than 2,000 years ago by invading Romans. " +
                    "The breed was widely used to pull carts and to drive cattle to and from their pastures and to protect farms from predators. " +
                    "Bernese Mountain Dogs, also called Berners, are noted for their hardiness. " +
                    "The dog is characterized by its broad chest, hanging V-shaped ears, and a long, silky, black coat with rust-colored spots on the chest " +
                    "and forelegs and over the eyes and white on the chest, nose, tail tip, and, sometimes, feet. " +
                    "The American Kennel Club recognized the Bernese Mountain Dog in 1937.",
                    ImagePath = "bernese_mountain_dog.jpg"
                },
                new Dog()
                {
                    Name = "Beagle",
                    Description = "Small hound dog breed popular as both a pet and a hunter. " +
                    "It looks like a small foxhound and has large brown eyes, hanging ears, and a short coat, usually a combination of black, tan, and white. " +
                    "The Beagle is a solidly built dog, heavy for its height. " +
                    "It generally excels at hunting (called beagling) rabbit or hare and is typically an alert, affectionate dog. " +
                    "There are two varieties recognized by the American Kennel Club and other breeding groups: " +
                    "those standing 13 inches (33 cm) or less at the withers and weighing under 20 pounds (9 kg) " +
                    "and those standing more than 13 inches but not exceeding 15 inches (38 cm) at the withers and weighing 20-30 pounds (9-14 kg).",
                    ImagePath = "beagle.jpg"
                },
                new Dog()
                {
                    Name = "Chihuahua",
                    Description = "Smallest recognized dog breed, named for the Mexican state of Chihuahua, where it was first noted in the mid-19th century. " +
                    "The Chihuahua is thought to have derived from the Techichi, a small mute dog kept by the Toltec people of Mexico as long ago as the 9th century CE, " +
                    "and it is a saucy-looking alert dog that is sturdier than its small build would suggest. " +
                    "It has a rounded head, large erect ears, prominent eyes, and a compact body. " +
                    "The coat is variable in color and may be either smooth and glossy or long and soft. " +
                    "It is valued as a spirited companion especially suited to apartment living. The American Kennel Club formally recognized the Chihuahua in 1904.",
                    ImagePath = "chihuahua.jpg"
                },
                new Dog() 
                {
                    Name = "Boxer",
                    Description = "Smooth-haired working dog named for its manner of “boxing” with its sturdy front paws when fighting. " +
                    "The Boxer, developed in Germany but with roots traceable to ancient Assyria, includes strains of Bulldog and Great Dane in its heritage. " +
                    "Historically, the dog was a big-game hunter. " +
                    "“In medieval times,” reports the American Kennel Club, the breed’s larger ancestor (the Bullenbeisser) was “used by noblemen to run down, catch, " +
                    "and hold such formidable opponents as bear, bison, and wild boar on vast ducal estates.” " +
                    "Because of its reputation for courage, aggressiveness, and intelligence, " +
                    "the Boxer has been widely used in police work but is also valued as a watchdog and a companion. " +
                    "It is a trim, squarely built dog with a short square-shaped muzzle, a black mask on its face, " +
                    "and a shiny short-haired coat of fawn (reddish brown) or brindle.",
                    ImagePath = "boxer.jpg"
                }
            ];
        }
    }
}