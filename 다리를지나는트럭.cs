using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

// 각 트럭의 정보를 저장할 클래스
class Truck
{
        public int weight;  // 트럭의 무게
        public int count;   // 현재 트럭이 지나가고 있는 다리길이 (시간)

        public Truck(int w, int cnt)
        {
            weight = w;
            count = cnt;
        }
}

public class Solution
{
        public int solution(int bridge_length, int weight, int[] truck_weights)
        {
            int answer = 0;

            // 다리를 건너기전 트럭 대기열을 저장할 큐
            Queue<int> truck_queue = new Queue<int>(truck_weights);
            // 현재 다리를 건너가고 있는 트럭정보를 저장할 리스트
            List<Truck> bridge_list = new List<Truck>();

            // 현재 다리를 건너는 트럭들의 총 무게
            int current_weight = 0;
            
            while(truck_queue.Count > 0 || bridge_list.Count > 0)
            {
                answer++;

                // 현재 다리를 건너는 트럭들의 시간을 각각 증가 시킨다.

                // 아래 반복문을 실행할 때 i를 0부터 시작해서 순차적으로 실행할 경우,
                // RemoveAt가 실행되면서 반복 조건문에 있는 bridge_list.Count가 감소하여
                // 뒤에 있는 리스트 요소가 정상적으로 삭제되지 않으므로 반드시 역순으로 실행해야 한다.
                for (int i = bridge_list.Count -1; i >= 0; --i)
                {
                    bridge_list[i].count++;     // 각각의 트럭의 시간 증가

                    // 트럭이 다리길이를 통과할 경우 총 다리무게에서 삭감하고 리스트에서도 삭제
                    if (bridge_list[i].count >= bridge_length)
                    {
                        current_weight -= bridge_list[i].weight;
                        bridge_list.RemoveAt(i);
                    }
                }

                if (truck_queue.Count > 0)
                {
                    int temp_weight = truck_queue.Peek();

                    // 현재 다리를 지나는 트럭과 다음 진입할 트럭의 무게가 허용치 이내일 경우,
                    // 다리 총무게에 진입하는 트럭무게를 합산하고 다리를 건너는 트럭리스트에 추가
                    if (current_weight + temp_weight <= weight)
                    {
                        current_weight += truck_queue.Dequeue();
                        Truck temp_truck = new Truck(temp_weight, 0);
                        bridge_list.Add(temp_truck);
                    }
                }
            }
            return answer;
        }
}