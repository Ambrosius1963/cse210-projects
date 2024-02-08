// ==================================
//          ScriptureGen
// ----------------------------------
//     - List<string> _scriptures
// ----------------------------------
//     + GetRandomScripture()
// ==================================


public class ScriptureGen
{
    private List<string> _scriptures = new List<string>{

        "Ether 12:27 ~ 'And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.'",
        "Mosiah 2:17 ~ 'And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.'",
        "Moroni 10:4-5 ~ 'And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things.'",
        "2 Nephi 2:25 ~ 'Adam fell that men might be; and men are, that they might have joy.'",
        "Alma 32:21 ~ 'And now as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true.'",
        "Moroni 7:45 ~ 'And charity suffereth long, and is kind, and envieth not, and is not puffed up, seeketh not her own, is not easily provoked, thinketh no evil, and rejoiceth not in iniquity but rejoiceth in the truth, beareth all things, believeth all things, hopeth all things, endureth all things.'",
        "Mosiah 2:41 ~ 'And moreover, I would desire that ye should consider on the blessed and happy state of those that keep the commandments of God. For behold, they are blessed in all things, both temporal and spiritual; and if they hold out faithful to the end they are received into heaven, that thereby they may dwell with God in a state of never-ending happiness. O remember, remember that these things are true; for the Lord God hath spoken it.'",
        "Alma 34:32 ~ 'For behold, this life is the time for men to prepare to meet God; yea, behold the day of this life is the day for men to perform their labors.'",
        "Alma 36:3 ~ 'And now, O my son Helaman, behold, thou art in thy youth, and therefore, I beseech of thee that thou wilt hear my words and learn of me; for I do know that whosoever shall put their trust in God shall be supported in their trials, and their troubles, and their afflictions, and shall be lifted up at the last day.'",
        "3 Nephi 11:29 ~ 'For verily, verily I say unto you, he that hath the spirit of contention is not of me, but is of the devil, who is the father of contention, and he stirreth up the hearts of men to contend with anger, one with another.'",
        "2 Nephi 25:26 ~ 'And we talk of Christ, we rejoice in Christ, we preach of Christ, we prophesy of Christ, and we write according to our prophecies, that our children may know to what source they may look for a remission of their sins.'",
        "Moroni 7:47 ~ 'But charity is the pure love of Christ, and it endureth forever; and whoso is found possessed of it at the last day, it shall be well with him.'",
        "2 Nephi 2:27 ~ 'Wherefore, men are free according to the flesh; and all things are given them which are expedient unto man. And they are free to choose liberty and eternal life, through the great Mediator of all men, or to choose captivity and death, according to the captivity and power of the devil; for he seeketh that all men might be miserable like unto himself.'",
        "Alma 37:37 ~ 'Counsel with the Lord in all thy doings, and he will direct thee for good; yea, when thou liest down at night lie down unto the Lord, that he may watch over you in your sleep; and when thou risest in the morning let thy heart be full of thanks unto God; and if ye do these things, ye shall be lifted up at the last day.'",
        "Helaman 5:12 ~ 'And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.'",
        "1 Nephi 3:7 ~ 'And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.'",
        "Alma 37:35 ~ 'O, remember, my son, and learn wisdom in thy youth; yea, learn in thy youth to keep the commandments of God.'",
        "Mosiah 3:19 ~ 'For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love, willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father.'",
        "Alma 32:27 ~ 'But behold, if ye will awake and arouse your faculties, even to an experiment upon my words, and exercise a particle of faith, yea, even if ye can no more than desire to believe, let this desire work in you, even until ye believe in a manner that ye can give place for a portion of my words.'",
        "Moroni 10:32 ~ 'Yea, come unto Christ, and be perfected in him, and deny yourselves of all ungodliness; and if ye shall deny yourselves of all ungodliness, and love God with all your might, mind and strength, then is his grace sufficient for you, that by his grace ye may be perfect in Christ; and if by the grace of God ye are perfect in Christ, ye can in nowise deny the power of God.'",
        "Alma 37:35 ~ 'O, remember, my son, and learn wisdom in thy youth; yea, learn in thy youth to keep the commandments of God.'",
        "Mosiah 4:9 ~ 'Believe in God; believe that he is, and that he created all things, both in heaven and in earth; believe that he has all wisdom, and all power, both in heaven and in earth; believe that man doth not comprehend all the things which the Lord can comprehend.'",
    };

    public string GetRandomScripture(){
        Random random = new Random();
        int index = random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}
