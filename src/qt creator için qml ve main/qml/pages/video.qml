import QtQuick 2.0






Item  {
    id: root
    width: 200; height: 230

    property double startTime: 0
    property int secondsElapsed: 0

    function restartCounter()  {

            root.startTime = 0;

        }

    function timeChanged()  {
        if(root.startTime==0)
        {
            root.startTime = new Date().getTime(); //returns the number of milliseconds since the epoch (1970-01-01T00:00:00Z);
        }



        var currentTime = new Date().getTime();
        root.secondsElapsed = (currentTime-startTime)/1000;
    }

    Timer  {
        id: elapsedTimer
        interval: 100;
        running: true;
        repeat: true;
        onTriggered: root.timeChanged()
    }

    Text {
        id: counterText
        color: "#ffffff"
        text: root.secondsElapsed
        anchors.fill: parent
        font.pointSize: 22
    }
}
