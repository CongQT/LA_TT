import { Button, Form, Input, Radio } from "antd";
import { Link } from "react-router-dom";

function QuenMKComponent(){
    return (
    <div className="dangki">
    <div className="title">
      Quên mật khẩu
    </div>
    <Form
    layout="vertical"
    name="form_in_modal"
    initialValues={{
      modifier: 'public',
    }}
    
  >
    <Form.Item
    name="email"
    label="Email"
    rules={[
        {
        required: true,
        message: 'Điền email',
        },
    ]}
    className="in"
    >
    <Input style={{width:'300px'}}/>
    </Form.Item>

  </Form>
  <Button className="guibt">
    <Link to={"/reset"}>Gửi</Link>
  </Button>
    </div>
    )
}
export default QuenMKComponent;