# Azure iot hub

1. 대칭키를 이용한 등록시 SHA256으로 키발급 처리

2. Azure 포털에서 DSP에 개별등록으로 위 발급 키로 디바이스 정보 등록 = DEVICE 상태 Unassigned 
(여기까지는 DSP에만 등록된 상태)

3. ID범위 입력 + 기 등록된 아이디 + 기 등록한 대칭키 로 디바이스 Assigned 등록 처리
(iot hub에 device로 등록되어 사용중인 상태로 변경됨)

4. 위정보를 통해 IOT Hub Url로 메세지 발송 처리 테스트

5. 메세지 라우팅을 통해 연결된 값 확인

# [선행 조건]
```
azure iot hub 등록
azure iot hub dsp 등록
azure 스토리지 계정 등록
azure iot hub 메세지 라우팅 등록
```


