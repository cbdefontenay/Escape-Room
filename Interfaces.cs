namespace Escape
{
    //Interface for Cartography
    interface ICartography
    {
        void UserName();
        void FirstRoom();
        void BlueRoom();
        string TreeRoom();
        void SeaAnimalRoom();
    }

    //Interface fights
    interface IFights
    {

        string FightGuards(string path, string firstAttack, string secondAttack, string thirdAttack, string fourthAttack);
        string DetermineFightOutcome(string userAttack, string guardAttack);
    }

    // Interface for Drawing
    interface IDrawing
    {
        void Cart();
        void OldMan();
        void Tree();
        void Guards();
        void Weapons();
        void Fish();
        void SeaTurtle();
    }

    //Interface for Tips
    interface ITips
    {
        void FirstRoomTips(string tip);
    }
}
