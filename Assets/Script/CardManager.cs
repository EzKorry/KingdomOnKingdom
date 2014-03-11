using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CardManager  {

    private List<CardSupporter> cardSupporterList;
    private List<Condition> conditionList;

    private int cardID;
    private string cardName;
    private string description;
    private Texture2D cardTexture;
    private List<Ability> abilityList = new List<Ability>();
    private Dictionary<string, int> stat = new Dictionary<string, int>(7);
    private int healthMax;
    private int healthCurrent;
    private int manaMax;
    private int manaCurrent;
    private int type;
    private int species;
    private int leadershipConsumption;
    private int pointConsumption;
    private int leadership;


    // 그냥 초기화 함수에서 초기화할 필요가 없는 것들
    private int shield = 0;
    private int attackAvailableCount = 1;
    private int moveAvailableCount=1;


    //통계용 자료
    private Dictionary<string, int> record = new Dictionary<string, int>();
  
    
    
    // 생성자
    public CardManager(CardSoldier card) {
        initSoldier(card);
    }
    public CardManager(CardPlayer card) {
        initPlayer(card);
    }


    // 유닛 초기화
    private void initUnit(CardUnit card) {

        stat.Add("healthRegen", card.healthRegen);
        stat.Add("manaRegen", card.manaRegen);
        stat.Add("attack", card.attack);
        stat.Add("defense", card.defense);
        stat.Add("spell", card.spell);
        stat.Add("mobility", card.mobility);
        stat.Add("range",card.range);
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

        healthMax = card.health;
        healthCurrent = card.health;
        
        manaMax = card.mana;
        manaCurrent = card.manaRegen;
    
        type = card.type;
        species = card.species;
   
        abilityList = card.abilityList;

        Debug.Log(card.abilityList);

    }




    // 군카 초기화
    private void initSoldier(CardSoldier a) {


        initUnit(a as CardUnit);
        
        leadershipConsumption = a.leadershipConsumption;
        pointConsumption = a.pointConsumption;
        
    }


    // 플카 초기화
    private void initPlayer(CardPlayer a) {

        initUnit(a);

        leadership = a.leadership;




    }
    // 매 턴마다 초기화할 것
    public void initEachPeriod() {
    
    }

    // 보조 카드 추가
    public void addCardSupporter(CardSupporter Card) {
    
    }

    // 보조 카드 제거
    public void delCardSupporter(CardSupporter Card) {
    
    }

    // 상태 이상 추가
    public void addCondition(Condition condition) {

    }

    // 상태 이상 제거
    public void delCondition(Condition condition) {

    }

    // 현재 상태를 점검하여 적절하게 처리.
    private void check() {
        // 체력이 0보다 낮으면 뒤짐 처리.
        // 마나가 0보다 낮으면 마나 0.
        // 
    
    }

    // 데미지 받음 ㅜ
    public void damage(int amount) {
        
    }

    // 고정뎀 받음.
    public void damageConst(int amount) {
    
    
    }

    // 컨디션 리턴.
    public readonly List<Condition> getCondition() {
        return conditionList;
    
    }

    // 효과 리턴.
    public readonly List<Ability> getAbility() {
        return abilityList;

    }

    // 스탯 설정
    public void modifyStat(string key, int value, int modifier) {
        if (modifier == Modifier.Set) {
            stat[key] = value;
        }
        if (modifier == Modifier.Add) {
            stat[key] += value;

        }
        if (modifier == Modifier.Subtract){
            stat[key] -= value;
        }

        check();
                
    }
    
    // 죽었을 때
    public void die() {
    }





    
    


}
