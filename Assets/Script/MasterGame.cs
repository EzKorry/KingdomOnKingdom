using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class MasterGame  {


    public static Dictionary<string, int> recordTotal;
    public static Dictionary<int, List<Modifier>> modifiers;
    public static Dictionary<int, List<Effect>> effects;
    public static Dictionary<Coordinate, CardManager> CardsOnField;
    public const int MaxX = 10;
    public const int MaxY = 10;


    // 생성자
    static MasterGame() {

        modifiers.Add(ConditionTiming.Attack, new List<Modifier>());
       
        
    }

    // 제일 게임 시작할 때
    public static void initAtFirst() {

        // 땅 생성
        // 각 지형마다 좌표 할당
        // 구조물 생성
        // 네트워크 관련 초기화

    }


    // 공격
    public static void attack(CardManager main, CardManager target, int damage, int attackType) {

        target.damage(damage, attackType);




        // 애니메이션

    }

    // 카드 움직임
    public static void move(CardManager main, Coordinate coord) {
        CardManager temp = CardsOnField[coord];



        // 애니메이션


    
    }


    // 카드 소환
    public static void summon(CardSoldier card, Coordinate coord) {
        CardsOnField.Add(coord, new CardManager(card, coord));




        //애니메이션
        
    
    }


    // 누군가 공격당했을 때 조건 검색.
    public static void expectEffectsWhenSomeoneAttacked(CardSoldier main, CardSoldier target) {
    
    
    }
    
    // 턴 시작시 조건검색
    public static void expectEffectsWhenPeriodStart() {
    
    }

    // 누가 움직였을 때 조건 검색.
    public static void expectEffectsWhenSomeoneMoved(CardSoldier main, Coordinate beforeCor, Coordinate afterCor) {
    
    }

    public static void expectEffectsWhenPeriodEnded() {
    
    }

    public static void expectEffectsWhenSomeoneUseEffect(CardSoldier main, Ability ability) {
    
    }
    

    


    // 카드매니저 리스트의 스탯 필터
    public static List<CardManager> StatFilter(List<CardManager> list, string key, int value, int op) {
        List<CardManager> tempList = new List<CardManager>(list);
        foreach (CardManager card in list) {
            if (!card.isStat(key, value, op)) {
                tempList.Remove(card);
            }
        
        }

        return tempList;

    }

   
	
}
