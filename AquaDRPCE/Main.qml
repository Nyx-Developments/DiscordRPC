import QtQuick 2.7
import QtQuick.Controls 2.0
import QtQuick.Layouts 1.0
import DRPCE 1.1

ApplicationWindow {
    id: applicationWindow
    visible: true
    width: 764
    height: 297
    maximumWidth: 764
    maximumHeight: 297
    minimumHeight: 297
    minimumWidth: 764
    title: qsTr("Discord RPC Emulator")
    Rectangle {
      id: rectangle
      color: "#303030"
      width: 764
      height: 297

      Text {
          id: dCIDTxt
          x: 8
          y: 12
          width: 125
          height: 22
          color: "#ffffff"
          text: qsTr("Discord Client ID")
          style: Text.Normal
          font.weight: Font.Light
          font.pixelSize: 15
          horizontalAlignment: Text.AlignHCenter
          verticalAlignment: Text.AlignVCenter
          anchors.top: parent.top
          anchors.topMargin: 12
          styleColor: "#ffffff"
          font.family: "Verdana"
      }

      TextField {
          id: dID
          x: 139
          y: 321
          width: 211
          height: 30
          text: qsTr("")
          font.weight: Font.Light
          font.pixelSize: 15
          color: "#303030"
          anchors.top: parent.top
          anchors.topMargin: 8
          placeholderText: "ID HERE"
          horizontalAlignment: Text.AlignHCenter
          font.family: "Verdana"
      }
      Text {
          id: dTxt
          x: 8
          y: 12
          width: 58
          height: 22
          color: "#ffffff"
          text: qsTr("Details")
          style: Text.Normal
          font.weight: Font.Light
          font.pixelSize: 15
          horizontalAlignment: Text.AlignLeft
          verticalAlignment: Text.AlignVCenter
          anchors.top: parent.top
          anchors.topMargin: 48
          styleColor: "#ffffff"
          font.family: "Verdana"
      }

      TextField {
          id: detailTxt
          x: 72
          y: 321
          width: 278
          height: 30
          text: qsTr("")
          font.weight: Font.Light
          font.pixelSize: 15
          color: "#303030"
          anchors.top: parent.top
          anchors.topMargin: 44
          placeholderText: ""
          horizontalAlignment: Text.AlignHCenter
          font.family: "Verdana"
      }
      Text {
          id: sLbl
          x: 8
          y: 12
          width: 58
          height: 22
          color: "#ffffff"
          text: qsTr("State")
          style: Text.Normal
          font.weight: Font.Light
          font.pixelSize: 15
          horizontalAlignment: Text.AlignLeft
          verticalAlignment: Text.AlignVCenter
          anchors.top: parent.top
          anchors.topMargin: 84
          styleColor: "#ffffff"
          font.family: "Verdana"
      }

      TextField {
          id: stateTxt
          x: 72
          y: 321
          width: 278
          height: 30
          text: qsTr("")
          font.weight: Font.Light
          font.pixelSize: 15
          color: "#303030"
          anchors.top: parent.top
          anchors.topMargin: 80
          placeholderText: ""
          horizontalAlignment: Text.AlignHCenter
          font.family: "Verdana"
      }

      CheckBox {
          id: checkBox
          x: 8
          y: 112
          width: 342
          height: 40
          text: qsTr("<font color=\"white\">Use Image Emulate</font>")
          hoverEnabled: false
          checkState: Qt.Unchecked
          font.pixelSize: 15
          font.family: "Verdana"
          checked: false
      }
      Text {
          id: lILabel
          x: 8
          y: 12
          width: 131
          height: 22
          color: "#ffffff"
          text: qsTr("Large Image Key")
          style: Text.Normal
          font.weight: Font.Light
          font.pixelSize: 15
          horizontalAlignment: Text.AlignLeft
          verticalAlignment: Text.AlignVCenter
          anchors.top: parent.top
          anchors.topMargin: 154
          styleColor: "#ffffff"
          font.family: "Verdana"
      }

      TextField {
          id: lITxt
          x: 145
          y: 321
          width: 205
          height: 30
          text: qsTr("")
          font.weight: Font.Light
          font.pixelSize: 15
          color: "#303030"
          anchors.top: parent.top
          anchors.topMargin: 150
          placeholderText: ""
          horizontalAlignment: Text.AlignHCenter
          font.family: "Verdana"
      }
      Text {
          id: sILabel
          x: 8
          y: 12
          width: 131
          height: 22
          color: "#ffffff"
          text: qsTr("Small Image Key")
          style: Text.Normal
          font.weight: Font.Light
          font.pixelSize: 15
          horizontalAlignment: Text.AlignLeft
          verticalAlignment: Text.AlignVCenter
          anchors.top: parent.top
          anchors.topMargin: 186
          styleColor: "#ffffff"
          font.family: "Verdana"
      }

      TextField {
          id: sITxt
          x: 145
          y: 321
          width: 205
          height: 30
          text: qsTr("")
          font.weight: Font.Light
          font.pixelSize: 15
          color: "#303030"
          anchors.top: parent.top
          anchors.topMargin: 187
          placeholderText: ""
          horizontalAlignment: Text.AlignHCenter
          font.family: "Verdana"
      }
      Text {
          id: lILabelTxt
          x: 8
          y: 12
          width: 131
          height: 22
          color: "#ffffff"
          text: qsTr("Large Image Text")
          style: Text.Normal
          font.weight: Font.Light
          font.pixelSize: 15
          horizontalAlignment: Text.AlignLeft
          verticalAlignment: Text.AlignVCenter
          anchors.top: parent.top
          anchors.topMargin: 222
          styleColor: "#ffffff"
          font.family: "Verdana"
      }

      TextField {
          id: lITxtIp
          x: 145
          y: 321
          width: 205
          height: 30
          text: qsTr("")
          font.weight: Font.Light
          font.pixelSize: 15
          color: "#303030"
          anchors.top: parent.top
          anchors.topMargin: 222
          placeholderText: ""
          horizontalAlignment: Text.AlignHCenter
          font.family: "Verdana"
      }
      Text {
          id: sILabelTxt
          x: 8
          y: 12
          width: 131
          height: 22
          color: "#ffffff"
          text: qsTr("Small Image Text")
          style: Text.Normal
          font.weight: Font.Light
          font.pixelSize: 15
          horizontalAlignment: Text.AlignLeft
          verticalAlignment: Text.AlignVCenter
          anchors.top: parent.top
          anchors.topMargin: 262
          styleColor: "#ffffff"
          font.family: "Verdana"
      }

      TextField {
          id: sITxtIp
          x: 145
          y: 321
          width: 205
          height: 30
          text: qsTr("")
          font.weight: Font.Light
          font.pixelSize: 15
          color: "#303030"
          anchors.top: parent.top
          anchors.topMargin: 258
          placeholderText: ""
          horizontalAlignment: Text.AlignHCenter
          font.family: "Verdana"
      }
      CheckBox {
          id: pCheck
          x: 356
          y: 3
          width: 400
          height: 40
          text: qsTr("<font color=\"white\">Use Party Emulate</font>")
          hoverEnabled: false
          checkState: Qt.Unchecked
          font.pixelSize: 15
          font.family: "Verdana"
          checked: false
      }
      Text {
          id: pIDlbl
          x: 356
          y: 12
          width: 64
          height: 22
          color: "#ffffff"
          text: qsTr("Party ID")
          style: Text.Normal
          font.weight: Font.Light
          font.pixelSize: 15
          horizontalAlignment: Text.AlignLeft
          verticalAlignment: Text.AlignVCenter
          anchors.top: parent.top
          anchors.topMargin: 48
          styleColor: "#ffffff"
          font.family: "Verdana"
      }

      TextField {
          id: pIDSTR
          x: 426
          y: 321
          width: 330
          height: 30
          text: qsTr("")
          font.weight: Font.Light
          font.pixelSize: 15
          color: "#303030"
          anchors.top: parent.top
          anchors.topMargin: 44
          placeholderText: ""
          horizontalAlignment: Text.AlignHCenter
          font.family: "Verdana"
      }
      Text {
          id: pSLbl
          x: 356
          y: 12
          width: 78
          height: 22
          color: "#ffffff"
          text: qsTr("Party Size")
          style: Text.Normal
          font.weight: Font.Light
          font.pixelSize: 15
          horizontalAlignment: Text.AlignLeft
          verticalAlignment: Text.AlignVCenter
          anchors.top: parent.top
          anchors.topMargin: 84
          styleColor: "#ffffff"
          font.family: "Verdana"
      }

      TextField {
          id: pSize
          x: 440
          y: 321
          width: 316
          height: 30
          text: qsTr("")
          font.weight: Font.Light
          font.pixelSize: 15
          color: "#303030"
          anchors.top: parent.top
          anchors.topMargin: 80
          placeholderText: ""
          horizontalAlignment: Text.AlignHCenter
          font.family: "Verdana"
      }
      Text {
          id: pMSlbl
          x: 356
          y: 12
          width: 116
          height: 22
          color: "#ffffff"
          text: qsTr("Party Max Size")
          style: Text.Normal
          font.weight: Font.Light
          font.pixelSize: 15
          horizontalAlignment: Text.AlignLeft
          verticalAlignment: Text.AlignVCenter
          anchors.top: parent.top
          anchors.topMargin: 121
          styleColor: "#ffffff"
          font.family: "Verdana"
      }

      TextField {
          id: pMaxSize
          x: 473
          y: 321
          width: 283
          height: 30
          text: qsTr("")
          font.weight: Font.Light
          font.pixelSize: 15
          color: "#303030"
          anchors.top: parent.top
          anchors.topMargin: 117
          placeholderText: ""
          horizontalAlignment: Text.AlignHCenter
          font.family: "Verdana"
      }
      CheckBox {
          id: useTSEmu
          x: 356
          y: 150
          width: 400
          height: 40
          text: qsTr("<font color=\"white\">Use Timestamp Emulate</font>")
          hoverEnabled: false
          checkState: Qt.Unchecked
          font.pixelSize: 15
          font.family: "Verdana"
          checked: false
      }
      Button {
          id: enableEmulate
          x: 356
          y: 188
          width: 194
          height: 28
          text: qsTr("Emulate RPC")
          font.weight: Font.Light
          display: AbstractButton.TextBesideIcon
          font.pixelSize: 15
          font.family: "Verdana"
          onClicked: {
              test.init(dID.text,detailTxt.text,stateTxt.text,checkBox.checked,lITxt.text,sITxt.text,lITxtIp.text,sITxtIp.text,pCheck.checked,pIDSTR.text,pSize.text,pMaxSize.text,useTSEmu.checked)
          }
      }
      
      Button {
          id: deEmulate
          x: 356
          y: 224
          width: 194
          height: 28
          text: qsTr("De-emulate RPC")
          font.weight: Font.Light
          font.family: "Verdana"
          font.pixelSize: 15
          display: AbstractButton.TextBesideIcon
          onClicked: {
              test.deinit();
          }
      }
      Button {
          id: changeRPC
          x: 556
          y: 188
          width: 200
          height: 28
          text: qsTr("Change RPC")
          font.weight: Font.Light
          font.family: "Verdana"
          font.pixelSize: 15
          display: AbstractButton.TextBesideIcon
          onClicked: {
              test.setRPC(detailTxt.text,stateTxt.text,checkBox.checked,lITxt.text,sITxt.text,lITxtIp.text,sITxtIp.text,pCheck.checked,pIDSTR.text,pSize.text,pMaxSize.text,useTSEmu.checked);
          }
      }

      Button {
          id: mnDcRPC
          x: 356
          y: 259
          width: 400
          height: 28
          text: qsTr("Manage your Discord RPC Here")
          font.pixelSize: 15
          font.weight: Font.Light
          display: AbstractButton.TextBesideIcon
          font.family: "Verdana"
          onClicked: {
              test.manageRPC();
          }
      }
   }
    QmlType {
      id: test
      Component.onCompleted: function() {
          // We can return .NET types (even ones not registered with Qml)
          var netObject = test.createNetObject();
      }
    }
}


