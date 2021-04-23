import QtQuick 2.0
import "script.js" as MyScript

Rectangle {
    id: button
    width: 200; height: 80; color: "lightsteelblue"

    MouseArea {
        id: mousearea
        anchors.fill: parent
         signal messageRequired
        objectName: "myButton"

        onPressed: {



            // arbitrary JavaScript expression
            label.text = "Webview başlatılıyor."
              mousearea.clicked.connect(MyScript.messageRequired)
            onClicked: messageRequired()


        }
//        onReleased: {
//            // arbitrary JavaScript expression
//            label.text = "Click Me!"
//        }

    }

    Component.onCompleted: {
//           mouseArea.clicked.connect(MyScript.startTimer) //direk cagir
       }

    Text {
        id: label
        anchors.centerIn: parent
        text: "Ankete gitmek için tıklayınız."
    }


}
