using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CardManager  {

    private List<CardSupporter> cardSupporterList;
    private List<Modifier> conditionList;

    private int cardID;
    private string cardName;
    private string description;
    private Texture2D cardTexture;
    private List<Ability> abilityList;
    private Coordinate currentCoordinate;

    //각종 스탯
    private Dictionary<string, int> stat;

    //통계용 자료
    private Dictionary<string, int> record;
  
    
    
    // 생성자
    public CardManager(CardSoldier card, Coordinate coordinate) {
        this.currentCoordinate = coordinate;
        initSoldier(card);
        

    }
    public CardManager(CardPlayer card, Coordinate coordinate) {
        this.currentCoordinate = coordinate;
        initPlayer(card);
        
    }


    // 유닛카드 초기화
    private void initUnit(CardUnit card) {

        cardSupporterList = new List<CardSupporter>();
        conditionList = new List<Modifier>();
        abilityList = new List<Ability>();
        stat = new Dictionary<string, int>();
        record = new Dictionary<string, int>();
        

        stat.Add("shield", 0);
        stat.Add("attackAvailableCount", 1);
        stat.Add("moveAvailableCount", 1);

        stat.Add("healthRegen", card.healthRegen);
        stat.Add("manaRegen", card.manaRegen);
        stat.Add("attack", card.attack);
        stat.Add("defense", card.defense);
        stat.Add("spell", card.spell);
        stat.Add("mobility", card.mobility);
        stat.Add("range",card.range);
        stat.Add("healthMax", card.health);
        stat.Add("healthCurrent", card.health);
        stat.Add("manaMax", card.mana);
        stat.Add("manaCurrent", card.mana);
        stat.Add("type", card.type);
        stat.Add("species", card.species);
        record.Add("moveCount",0);
        record.Add("moveAmount",0);
        record.Add("attackCount",0);
        record.Add("attackAmount",0);
        record.Add("spellCount",0);
        record.Add("damagedCount",0);
        record.Add("damagedAmount",0);


        cardName = card.cardName;
        cardID = card.cardID;
        description = card.description;
        cardTexture = card.cardTexture;

        
        abilityList = card.abilityList;



        Debug.Log(card.abilityList[0]);
        

    }

    // 군카 초기화
    private void initSoldier(CardSoldier card) {


        initUnit(card);
        stat.Add("leadershipConsumption", card.leadershipConsumption);
        stat.Add("pointConsumption", card.pointConsumption);
        
       
        
    }

    // 플카 초기화
    private void initPlayer(CardPlayer card) {

        initUnit(card);

        stat.Add("leadership", card.leadership);




    }

    // 매 턴마다 초기화할 것
    public void initEachPeriod() {
    
    }

    // 보조 카드 추가
    public void addCardSupporter(CardSupporter card) {

        cardSupporterList.Add(card);
        check();
    }

    // 보조 카드 제거
    public void delCardSupporter(CardSupporter card) {

        cardSupporterList.Remove(card);
        check();
    
    }

    // 상태 이상 추가
    public void addModifier(Modifier modifier) {

    }

    // 상태 이상 제거
    public void delModifier(Modifier modifier) {

    }

    // 현재 상태를 점검하여 적절하게 처리.
    private void check() {
        // 체력이 0보다 낮으면 뒤짐 처리.
        // 마나가 0보다 낮으면 마나 0.
        // 
    
    }

    // 데미지 받음 ㅜ
    public void damage(int amount, int attackType) {
        switch (attackType) {
        
            case AttackTypes.Physical:

                Debug.Log(cardName + "이(가) " + amount + "만큼의 물리 데미지를 입었다!");
                break;
            case AttackTypes.Magical:

                Debug.Log(cardName + "이(가) " + amount + "만큼의 고정 데미지를 입었다!");
                break;
            case AttackTypes.Absolute:

                Debug.Log(cardName + "이(가) " + amount + "만큼의 마법 데미지를 입었다!");
                break;
            default:
                break;
        }
       
        
    }


    // t상태이상 리턴.
    public List<Modifier> getModifier() {
        return conditionList;
    
    }

    // 효과 리턴.
    public List<Ability> getAbility() {
        return abilityList;

    }

    // 스탯 설정
    public void modifyStat(string key, int value, int valueModifier) {
        if (valueModifier == ValueModifier.Set) {
            stat[key] = value;
        }
        else if (valueModifier == ValueModifier.Add) {
            stat[key] += value;

        }
        else if (valueModifier == ValueModifier.Subtract){
            stat[key] -= value;
        }

        check();
                
    }

    // 스탯 리턴
    public int getStat(string key) {

        return stat[key];
    }

    // 레코드 리턴
    public int getRecord(string key) {
        return record[key];
    }
    
    // 죽었을 때
    public void die() {
    }


    // 스탯 조건
    public bool isStat(string key, int value, int op) {
        switch (op) {
            case Operator.Equal:
                return stat[key] == value;
            case Operator.SmallerThan:
                return stat[key] < value;
            case Operator.BiggerThan:
                return stat[key] > value;
            case Operator.EqualOrSmallerThan:
                return stat[key] <= value;
            case Operator.EqualOrBiggerThan:
                return stat[key] >= value;
            default:
                return false;
        }
    
    }

    





    
    


}
