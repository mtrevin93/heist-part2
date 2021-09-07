namespace Heist
{
    interface IRobber
    {
        string Name;
        int SkillLevel;
        int PercentageCut;
        void PerformSkill(bank bank);
    }
}